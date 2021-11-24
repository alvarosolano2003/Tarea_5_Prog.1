using Autofac;
using Domain.Interfaces;
using Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // No se ha agregado nada. Se usara cuando se agreguen cosas.
            var builder = new ContainerBuilder();

            //builder.RegisterType<BaseRepository>().As<IModel>();

            //var container = new builder.build(); 


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
