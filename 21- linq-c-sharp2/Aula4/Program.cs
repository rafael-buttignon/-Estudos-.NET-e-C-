//using AluraTunesData;
//using System.Drawing.Imaging;
//using System.IO;
//using ZXing;

//namespace Aula4
//{
//    public class Program
//    {
//        private const string Imagens = "Imagens";

//        static void Main(string[] args)
//        {
//            var barcoWriter = new BarcodeWriter();
//            barcoWriter.Format = BarcodeFormat.QR_CODE;
//            barcoWriter.Options = new ZXing.Common.EncodingOptions
//            {
//                Width = 100,
//                Height = 100
//            };

//            if (!Directory.Exists(Imagens))
//                Directory.CreateDirectory("Imagens");

//            using (var contexto = new AluraTunesEntities())
//            {
//                var queryFaixas =
//                from f in contexto.Faixas
//                select f;

//                queryFaixas.ToList();
//            }
//        }
//    }
//}
