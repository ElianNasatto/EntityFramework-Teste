using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Contexto contextozinho = new Contexto(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=C:\Users\elian\Documents\GitHub\EntityFramework-Teste\WindowsFormsApp2\WindowsFormsApp2\App_Data\Database1.mdf;Initial Catalog=aspnet-PreventUrlModifications;Integrated Security=True");
            Class1 classe = new Class1();
            classe.Id = 1;
            classe.Nome = "ola mundo";
            contextozinho.Class.Add(classe);
            contextozinho.Class.Remove(classe);
            contextozinho.SaveChanges();
        }
    }
}
