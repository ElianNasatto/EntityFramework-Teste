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

            Contexto contextozinho = new Contexto();
            Class1 classe = new Class1();
            classe.Id = 1;
            classe.Nome = "ola mundo";
            contextozinho.Class.Add(classe);
            contextozinho.SaveChanges();
        }
    }
}
