using Autofac;
using Domain.Interfaces;
using Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            var builder = new ContainerBuilder();

            builder.RegisterType<CalendarioRepository>().As<ICalendarioRepository>();

            var container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrestamo(container.Resolve<ICalendarioRepository>()));
        }
    }
}
