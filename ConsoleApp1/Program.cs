using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Pdf;
using Aspose.Cells;
using Aspose.Slides;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using Aspose.Cells.Rendering;
using Aspose.Words;
using Aspose.Words.Saving;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            word2Image();

            Console.ReadKey();
        }

        static void testMesOut()
        {

        }

        static void testMesIn()
        {
            ProductOrder productOrder = new ProductOrder(ActionType.A);

            productOrder["AUNR"] = "P0000010";
            productOrder["AUART"] = "0";
            productOrder["ATK"] = "2020040023";
            productOrder["ATKBEZ"] = "这是成产的成品";
            productOrder["SGE:B"] = "ST";
            productOrder["SGR:GUTB"] = 100m;

            ProductOperation productOperation = new ProductOperation(productOrder.Action);

            productOperation["ANR"] = "P00000100010";
            productOperation["AUART"] = productOrder["AUART"];
            productOperation["AGBEZ"] = "这是第一个工序";
            productOperation["EXTPRIO"] = "0";
            productOperation["MNR"] = "00000100";
            productOperation["MGRP"] = "";
            productOperation["OPT:PLAN"] = "M";
            productOperation["SGR:GUTP"] = 100m;
            productOperation["SGE:P"] = "ST";
            productOperation["VERARBCODE"] = "SYSTEM";
            productOperation["OPT:ERF"] = "N";
            productOperation["OPT:MULTIMNR"] = "N";
            productOperation["OPT:SNR"] = "E";

            OperationResource operationResource = new OperationResource(productOrder.Action);

            operationResource["ANR"] = productOperation["ANR"];
            operationResource["RESTYP"] = "WNR";
            operationResource["ATK"] = "M00001";
            operationResource["BEZ"] = "一号模具";
            operationResource["SGR:GUT"] = 1m;
            operationResource["SGE:GUT"] = "个";

            productOperation.ResourceList.Add(operationResource);

            OperationComponent operationComponent = new OperationComponent(productOrder.Action);

            operationComponent["ANR"] = productOperation["ANR"];
            operationComponent["ATK"] = "1000032320";
            operationComponent["ATKBEZ"] = "消耗的子物料";
            operationComponent["SLP"] = "1";
            operationComponent["SLS"] = 1;

            productOperation.ComponentList.Add(operationComponent);

            productOrder.OperationList.Add(productOperation);

            productOrder.Save("D:\\A\\HY72PPS.dat");
        }
        static void testapi()
        {
            string path = "\\\\Lsdwzjdit014\\a\\test.pdf";

            HttpClient client = new HttpClient();

            //client.DefaultRequestHeaders.Add("Content-Type", "application/json");
            HttpContent stringContent = new StringContent(JsonConvert.SerializeObject(new { filePath = path, fileContent = "" }));
            stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage httpResponseMessage = client.PostAsync("http://soa-dev.lonsid.cn/api/services/soa/convert/Pdf2Image", stringContent).GetAwaiter().GetResult();
            string rs = httpResponseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var result = JsonConvert.DeserializeObject<JObject>(rs).GetValue("result");
            string s = ((JObject)result).GetValue("fileContent").ToString();

            byte[] buf = Convert.FromBase64String(s);
            MemoryStream ms = new MemoryStream(buf);

            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            img.Save("D:\\A\\1.jpg", ImageFormat.Jpeg);

            Console.WriteLine();
        }
        static void word2Image()
        {
            string path = @"C:\Users\zhangzheng\Desktop\WMS方案设计相关.docx";

            Aspose.Words.Document document = new Aspose.Words.Document(path);

            ImageSaveOptions iso = new ImageSaveOptions(Aspose.Words.SaveFormat.Jpeg);
            iso.Resolution = 128;
            iso.PrettyFormat = true;
            iso.UseAntiAliasing = true;
            iso.PageIndex = 0;
            document.Save("d:\\A\\word.jpg", iso);
        }
        static void excel2Image()
        {
            string path = @"C:\Users\zhangzheng\Desktop\WMS开发进度.xlsx";
            Workbook workbook = new Workbook(path);

            //创建一个图表选项的对象
            ImageOrPrintOptions imgOptions = new ImageOrPrintOptions();
            //设置图片类型
            imgOptions.ImageFormat = ImageFormat.Jpeg;
            imgOptions.IsImageFitToPage = true;
            //获取第一张工作表
            Worksheet sheet = workbook.Worksheets[0];
            //创建一个纸张底色渲染对象
            SheetRender sr = new SheetRender(sheet, imgOptions);

            sr.ToImage(0, "d:\\A\\excel.jpg");
        }
        static void pdf2Image()
        {
            string path = "\\\\Lsdwzjdit014\\a\\test.pdf";//@"C:\Users\zhangzheng\Desktop\test.pdf";
            Aspose.Pdf.Document document = new Aspose.Pdf.Document(path);

            //document.Save("d:\\a.html", SaveFormat.Html);
            //document.Pages.Count

            MemoryStream memoryStream = new MemoryStream();
            Aspose.Pdf.Devices.Resolution reso = new Aspose.Pdf.Devices.Resolution(128);
            Aspose.Pdf.Devices.JpegDevice jpegDevice = new Aspose.Pdf.Devices.JpegDevice(reso, 100);
            jpegDevice.Process(document.Pages[1], memoryStream);

            System.Drawing.Image img = System.Drawing.Image.FromStream(memoryStream);
            img.Save("d:\\a.jpeg", ImageFormat.Jpeg);
 
        }
        static void ppt2Image()
        {
            string path = @"C:\Users\zhangzheng\Desktop\Visual Studio Team Services.pptx";
            Presentation presentation = new Presentation(path);

            MemoryStream stream = new MemoryStream();
            presentation.Save(stream, Aspose.Slides.Export.SaveFormat.Pdf);

            Aspose.Pdf.Document document = new Aspose.Pdf.Document(stream);
            MemoryStream memoryStream = new MemoryStream();
            Aspose.Pdf.Devices.Resolution reso = new Aspose.Pdf.Devices.Resolution(128);
            Aspose.Pdf.Devices.JpegDevice jpegDevice = new Aspose.Pdf.Devices.JpegDevice(reso, 100);
            jpegDevice.Process(document.Pages[1], memoryStream);

            System.Drawing.Image img = System.Drawing.Image.FromStream(memoryStream);
            img.Save("d:\\A\\ppt.jpg", ImageFormat.Jpeg);
        }
    }
}
