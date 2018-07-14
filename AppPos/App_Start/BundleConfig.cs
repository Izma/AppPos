using System.Web;
using System.Web.Optimization;

namespace AppPos
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery/jquery.js",
                        "~/Scripts/bootstrap/js/bootstrap.bundle.js",
                        "~/Scripts/jquery-easing/jquery.easing.js",
                        "~/Scripts/chart.js/Chart.js",
                        "~/Scripts/datatables/jquery.dataTables.js",
                        "~/Scripts/datatables/dataTables.bootstrap4.js",
                        "~/Scripts/sb-admin.js",
                        "~/Scripts/sb-admin-datatables.js",
                        "~/Scripts/sb-admin-charts.js"));

            bundles.Add(new ScriptBundle("~/Scripts/menu").Include(
                "~/Scripts/menu.js"
                ));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Scripts/bootstrap/css/bootstrap.css",
                      "~/Scripts/font-awesome/css/font-awesome.css",
                      "~/Scripts/datatables/dataTables.bootstrap4.css",
                      "~/Content/sb-admin.css"));
        }
    }
}
