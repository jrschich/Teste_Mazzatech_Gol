using CoreAplicacao.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Data
{
    public static class DbInitializer
    {
        public static void Initialize(GolContext context)
        {
            if (context.Airplanes.Any())
                return;

            var objs = new Airplane[]
            {
                new Airplane{
                    Modelo = "Boing",
                    QtdePassageiros = 500,
                    DataRegistro = DateTime.Now
                },
                new Airplane
                {
                    Modelo = "Airbus",
                    QtdePassageiros = 389,
                    DataRegistro = DateTime.Now
                }
            };

            context.AddRange(objs);
        }

    }
}
