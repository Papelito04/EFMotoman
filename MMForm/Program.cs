using MMForm.FormulariosData;

namespace MMForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new BaseForm());
=======
>>>>>>> b5227f10ea7e058d247e75fbc37b7aae1e906677

            //Application.Run(new Form1());

            //Application.Run(new Productos());


            //Application.Run(new HistorialForm());

            Application.Run(new BaseForm());
        }
    }
}