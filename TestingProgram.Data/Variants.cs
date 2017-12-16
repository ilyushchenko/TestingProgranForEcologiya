﻿using System.Collections.Generic;

namespace TestingProgram.Data
{
    public class Variants : IDataLoader<IVariant>
    {
        #region Коллекция вариантов
        public IEnumerable<IVariant> GetCollection()
        {
            return new IVariant[]
            {
                /// <summary>
                ///                 ГОРЯЧИЙ ИСТОЧНИК
                /// </summary>
                 /// <summary>
                /// Круглое устье
                /// </summary>
                new Variant(){VariantNuimber = 1, Material = "V205", PDK = 0.1, C_f = 0.025, H = 40, Temperature = 100, F = 3, M = 1.05, N = 1.05, Mx = 20, TemperatureAvg = -15, Diameter = 1.2, W0 = 6.5, Answer = 2.809},
                new Variant(){VariantNuimber = 2, Material = "S02", PDK = 0.5, C_f = 0.125, H = 25, Temperature = 130, F = 2.5, M = 1.12, N = 1, Mx = 9, TemperatureAvg = -14, Diameter = 1.3, W0 = 6.5, Answer = 6.956},
                new Variant(){VariantNuimber = 3, Material = "CO", PDK = 0.15, C_f = 0.04, H = 42, Temperature = 115, F = 2, M = 1.1, N = 1, Mx = 5, TemperatureAvg = -10, Diameter = 1.1, W0 = 6.5, Answer = 6.487},
                new Variant(){VariantNuimber = 4, Material = "Зола", PDK = 0.3, C_f = 0.1, H = 37, Temperature = 115, F = 3, M = 1.2, N = 1.02, Mx = 8, TemperatureAvg = -15, Diameter = 1.2, W0 = 6.5, Answer = 6.118},
                new Variant(){VariantNuimber = 5, Material = "V205", PDK = 0.1, C_f = 0.0005, H = 30, Temperature = 125, F = 2, M = 1.11, N = 1, Mx = 2, TemperatureAvg = -10, Diameter = 1.4, W0 = 7, Answer = 3.581},
                new Variant(){VariantNuimber = 6, Material = "V205", PDK = 0.1, C_f = 0.0005, H = 32, Temperature = 115, F = 1, M = 1.02, N = 1, Mx = 11, TemperatureAvg = -16, Diameter = 1.3, W0 = 7, Answer = 8.798},
                 /// <summary>
                /// Квадратное устье
                /// </summary>
                new Variant(){VariantNuimber = 7, Material = "CO", PDK = 0.15, C_f = 0.04, H = 35, Temperature = 133, F = 2.5, M = 1.08, N = 1.05, Mx = 8, TemperatureAvg = -20, SideA = 1, SideB = 1, W0 = 6.5, Answer = 3.61},
                new Variant(){VariantNuimber = 8, Material = "Бензол", PDK = 0.5, C_f = 0.13, H = 40, Temperature = 110, F = 2, M = 1.1, N = 1, Mx = 5, TemperatureAvg = -10, SideA = 1.1, SideB = 1.1, W0 = 6.5, Answer = 19.503},
                new Variant(){VariantNuimber = 9, Material = "Хлор", PDK = 0.3, C_f = 0.08, H = 25, Temperature = 130, F = 1, M = 1, N = 1, Mx = 2, TemperatureAvg = -18, SideA = 1.2, SideB = 1.2, W0 = 7, Answer = 11.387},
                new Variant(){VariantNuimber = 10, Material = "N02", PDK = 0.4, C_f = 0.3, H = 32, Temperature = 115, F = 1, M = 1.17, N = 1, Mx = 20, TemperatureAvg = -18, SideA = 1.1, SideB = 1.1, W0 = 7.5, Answer = 7.181},
                new Variant(){VariantNuimber = 11, Material = "NO2", PDK = 0.4, C_f = 0.03, H = 25, Temperature = 130, F = 1, M = 1, N = 1, Mx = 2, TemperatureAvg = -18, SideA = 1.4, SideB = 1.4, W0 = 7, Answer = 18.974},
                new Variant(){VariantNuimber = 12, Material = "Зола", PDK = 0.3, C_f = 0.1, H = 30, Temperature = 120, F = 2.5, M = 1.05, N = 1, Mx = 5, TemperatureAvg = -16, SideA = 1, SideB = 1, W0 = 7, Answer = 5.173},
                 /// <summary>
                /// Прямоугольное устье
                /// </summary>
                new Variant(){VariantNuimber = 13, Material = "CO", PDK = 0.15, C_f = 0.04, H = 30, Temperature = 120, F = 2, M = 1, N = 1.01, Mx = 6, TemperatureAvg = -10, SideA = 4, SideB = 2, W0 = 6.5, Answer = 3.12},
                new Variant(){VariantNuimber = 14, Material = "N02", PDK = 0.4, C_f = 0.1, H = 37, Temperature = 120, F = 2.5, M = 1.11, N = 1.02, Mx = 9, TemperatureAvg = -17, SideA = 5, SideB = 1, W0 = 7, Answer = 13.712},
                new Variant(){VariantNuimber = 15, Material = "Аммиак", PDK = 0.2, C_f = 0.05, H = 30, Temperature = 100, F = 1.5, M = 1.08, N = 1.2, Mx = 8, TemperatureAvg = -12, SideA = 3, SideB = 1, W0 = 6.5, Answer = 6.483},
                new Variant(){VariantNuimber = 16, Material = "S02", PDK = 0.5, C_f = 0.2, H = 35, Temperature = 120, F = 1, M = 1.17, N = 1, Mx = 15, TemperatureAvg = -16, SideA = 2, SideB = 1, W0 = 6.5, Answer = 27.904},
                new Variant(){VariantNuimber = 17, Material = "V2O5", PDK = 0.1, C_f = 0.025, H = 40, Temperature = 120, F = 2, M = 1, N = 1, Mx = 20, TemperatureAvg = -15, SideA = 5, SideB = 1, W0 = 6.5, Answer = 5.825},
                new Variant(){VariantNuimber = 18, Material = "V2O5", PDK = 0.1, C_f = 0.005, H = 25, Temperature = 110, F = 1, M = 1.07, N = 1, Mx = 7, TemperatureAvg = -15, SideA = 5, SideB = 1, W0 = 6.5, Answer = 4.479},
                /// <summary>
                ///                 ХОЛОДНЫЙ ИСТОЧНИК
                /// </summary>
                /// <summary>
                /// Круглое устье
                /// </summary>
                new Variant(){VariantNuimber=19, Material="V2O5", PDK=0.1,  C_f=0.025, H=40, Temperature=130, F=2.5, M=1.05, N=1.01, Mx=8, TemperatureAvg=-10, Diameter = 1.5, W0=7,   Answer=2.177},
                new Variant(){VariantNuimber=20, Material="O3",   PDK=0.16, C_f=0.04,  H=35, Temperature=105, F=3,   M=1.05, N=1,    Mx=6, TemperatureAvg=-15, Diameter = 2,   W0=6.5, Answer=2.531},
                new Variant(){VariantNuimber=21, Material="Зола", PDK=0.3,  C_f=0.08,  H=36, Temperature=100, F=2,   M=1,    N=1,    Mx=7, TemperatureAvg=-13, Diameter = 1,   W0=7,   Answer=4.572},
                new Variant(){VariantNuimber=22, Material="V2O5", PDK=0.1,  C_f=0.025, H=35, Temperature=120, F=2.5, M=1.05, N=1,    Mx=7, TemperatureAvg=-12, Diameter = 2,   W0=7,   Answer=1.847},
                new Variant(){VariantNuimber=23, Material="CO",   PDK=0.15, C_f=0.02,  H=40, Temperature=125, F=1,   M=1.18, N=1,    Mx=2, TemperatureAvg=-9,  Diameter = 1.4, W0=7,   Answer=9.05},
                new Variant(){VariantNuimber=24, Material="CO",   PDK=0.15, C_f=0.05,  H=35, Temperature=110, F=2,   M=1,    N=1,    Mx=8, TemperatureAvg=-10, Diameter = 1,   W0=7,   Answer=2.023},
                /// <summary>
                /// Квадратное устье
                /// </summary>
                new Variant(){VariantNuimber=25, Material="Сажа",   PDK=0.15, C_f=0.04,  H=28, Temperature=100, F=2,   M=1,    N=1.01, Mx=9,  TemperatureAvg=-18, SideA=2,   SideB = 2,   W0=7,   Answer=2.374},
                new Variant(){VariantNuimber=26, Material="Зола",   PDK=0.3,  C_f=0.08,  H=32, Temperature=125, F=3,   M=1.4,  N=1.1,  Mx=8,  TemperatureAvg=-15, SideA=2,   SideB = 2,   W0=6.5, Answer=3.266},
                new Variant(){VariantNuimber=27, Material="Ксилол", PDK=0.2,  C_f=0.05,  H=40, Temperature=130, F=2,   M=1,    N=1.01, Mx=8,  TemperatureAvg=-18, SideA=1.5, SideB = 1.5, W0=6.5, Answer=5.024},
                new Variant(){VariantNuimber=28, Material="Сажа",   PDK=0.15, C_f=0.05,  H=30, Temperature=115, F=1,   M=1,    N=1,    Mx=11, TemperatureAvg=-18, SideA=2,   SideB = 2,   W0=7,   Answer=4.572},
                new Variant(){VariantNuimber=29, Material="Ксилол", PDK=0.2,  C_f=0.05,  H=30, Temperature=120, F=3,   M=1.05, N=1.01, Mx=8,  TemperatureAvg=-16, SideA=2,   SideB = 2,   W0=7,   Answer=2.198},
                new Variant(){VariantNuimber=30, Material="О3",     PDK=0.16, C_f=0.025, H=35, Temperature=115, F=2.5, M=1.05, N=1,    Mx=7,  TemperatureAvg=-12, SideA=1.3, SideB = 1.3, W0=7,   Answer=2.973},
                /// <summary>
                /// Прямоугольное устье
                /// </summary>
                new Variant(){VariantNuimber=31, Material="Ксилол", PDK=0.2,  C_f=0.05,  H=35, Temperature=120, F=2,   M=1,    N=1.01, Mx=7, TemperatureAvg=-11, SideA=5,   SideB=2,   W0=7,   Answer=3.896},
                new Variant(){VariantNuimber=32, Material="Ксилол", PDK=0.2,  C_f=0.05,  H=35, Temperature=110, F=2,   M=1,    N=1.01, Mx=6, TemperatureAvg=-10, SideA=4,   SideB=2,   W0=6.5, Answer=4.247},
                new Variant(){VariantNuimber=33, Material="O3",     PDK=0.16, C_f=0.04,  H=32, Temperature=130, F=2.5, M=1.1,  N=1.01, Mx=7, TemperatureAvg=-14, SideA=3,   SideB=2,   W0=7,   Answer=2.111},
                new Variant(){VariantNuimber=34, Material="V2O5",   PDK=0.1,  C_f=0.025, H=33, Temperature=120, F=2,   M=2.05, N=1,    Mx=6, TemperatureAvg=-8,  SideA=6,   SideB=1,   W0=7,   Answer=2.188},
                new Variant(){VariantNuimber=35, Material="Ксилол", PDK=0.2,  C_f=0.05,  H=40, Temperature=130, F=3,   M=2,    N=1,    Mx=6, TemperatureAvg=-15, SideA=2,   SideB=1,   W0=7,   Answer=3.346},
                new Variant(){VariantNuimber=36, Material="O3",     PDK=0.16, C_f=0.04,  H=40, Temperature=110, F=2.3, M=1.4,  N=1.2,  Mx=7, TemperatureAvg=-15, SideA=2.3, SideB=1.5, W0=7,   Answer=3.513}
            };
        }
        #endregion
    }
}
