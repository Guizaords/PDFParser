using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Pdfocr;
using iText.Pdfocr.Tesseract4;

public class Program
{
    private static readonly Tesseract4OcrEngineProperties tesseract4OcrEngineProperties = new Tesseract4OcrEngineProperties();
    private static string OUTPUT_PDF = @"E:\trampo\Backup\30.8.2021\VT2.pdf";
    private const string DEFAULT_RGB_COLOR_PROFILE_PATH = @"profiles\sRGB_CS_profile.icm";
    public static string TESS_DATA_FOLDER = "tessdata";
    //private static List <FileInfo> LIST_IMAGES_OCR = new List
    //{
    //    new FileInfo(@"E:\trampo\Backup\ErroCompras.png")
    //};

    // referencia a pasta de destino
    public static readonly string DEST = @"E:\trampo\Backup\30.8.2021\parse";

    // referencia a pasta source
    public static readonly string SRC = @"E:\trampo\Backup\30.8.2021\VT.pdf";

    // cria a lista estatica para armazenar as imagens
    private static IList<FileInfo> LIST_IMAGES_OCR = new List<FileInfo>();
    static void Main()
    {
        // Cria o diretório para armazenar os dados
        Directory.CreateDirectory(DEST);

        //Chama a função antes do ocr
        new Program().ManipulatePdf(DEST);

        
        var tesseractReader = new Tesseract4LibOcrEngine(tesseract4OcrEngineProperties);
        tesseract4OcrEngineProperties.SetPathToTessData(new FileInfo(TESS_DATA_FOLDER));

        var properties = new OcrPdfCreatorProperties();
        properties.SetPdfLang("eng, por"); //we need to define a language to make it PDF/A compliant
        //properties.SetTextLayerName("text");
        //properties.SetImageLayerName("image");
        //properties.SetTextColor(DeviceRgb.RED);

        var ocrPdfCreator = new OcrPdfCreator(tesseractReader, properties);
        LIST_IMAGES_OCR.Clear();
        //adiciona dados da pasta parse à lista de imagens

        // Make a reference to a directory.
        DirectoryInfo di = new DirectoryInfo(DEST);
        // Get a reference to each file in that directory.
        FileInfo[] fiArr = di.GetFiles();
        // Display the names and sizes of the files.
        //Console.WriteLine("The directory {0} contains the following files:", di.Name);
        foreach (FileInfo f in fiArr)
        {
            if(f.Length > 90)
            {
                LIST_IMAGES_OCR.Add(f);
            }
        }
            

        ////obtendo objetos do pdf
        //foreach (string arquivo in Directory.GetFiles(DEST))        
        //{   
             

        //    LIST_IMAGES_OCR.Add(new FileInfo(arquivo));
        //}
        ////LIST_IMAGES_OCR.Add(DEST);
        try
        {
            using (var writer = new PdfWriter(OUTPUT_PDF))
            {
                ocrPdfCreator.CreatePdf(LIST_IMAGES_OCR, writer).Close();
            }
        }
        catch (Exception err)
        {

            Console.WriteLine("error " + err);
            return;
        }
        
                       
    }

    static PdfOutputIntent GetRgbPdfOutputIntent()
    {
        Stream @is = new FileStream(DEFAULT_RGB_COLOR_PROFILE_PATH, FileMode.Open, FileAccess.Read);
        return new PdfOutputIntent("", "", "", "sRGB IEC61966-2.1", @is);
    }

    protected void ManipulatePdf(string dest)
    {
        PdfDocument pdfDoc = new PdfDocument(new PdfReader(SRC));

        int numberOfPdfObject = pdfDoc.GetNumberOfPdfObjects();
        for (int i = 1; i <= numberOfPdfObject; i++)
        {
            PdfObject obj = pdfDoc.GetPdfObject(i);
            if (obj != null && obj.IsStream())
            {
                byte[] b;
                try
                {

                    // Get decoded stream bytes.
                    b = ((PdfStream)obj).GetBytes();
                }
                catch (FileLoadException err)
                {

                    // Get originally encoded stream bytes
                    b = ((PdfStream)obj).GetBytes(false);
                }

                using (FileStream fos = new FileStream(string.Format(dest + "/extract_streams{0}.png", i), FileMode.Create))
                {
                    fos.Write(b, 0, b.Length);
                }
            }
        }

        pdfDoc.Close();
    }
}
