namespace TestingProgram.Data
{
    /// <summary>
    /// Класс данных варианта
    /// </summary>
    public class Variant : IVariant
    {
        /// <summary>
        /// Номер варианта
        /// </summary>
        public int? VariantNuimber { get; set; }
        /// <summary>
        /// Исследуемое вещество
        /// </summary>
        public string Material { get; set; }
        /// <summary>
        /// ПДК, для данного вещества
        /// </summary>
        public double? PDK { get; set; }
        /// <summary>
        /// Фоновая концентрация загрезняющего вещества
        /// </summary>
        public double? C_f { get; set; }
        /// <summary>
        /// Высота трубы
        /// </summary>
        public double? H { get; set; }
        /// <summary>
        /// Температура выбрасываемого загрезняющего вещества
        /// </summary>
        public double? Temperature { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? F { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? M { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? N { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Mx { get; set; }
        /// <summary>
        /// Среднемесячная температура воздуха
        /// </summary>
        public double? TemperatureAvg { get; set; }
        /// <summary>
        /// Диметр трубы
        /// </summary>
        public double? Diameter { get; set; }
        /// <summary>
        /// Длинна сторона А 
        /// </summary>
        public double? SideA { get; set; }
        /// <summary>
        /// Длинна сторона Б
        /// </summary>
        public double? SideB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? W0 { get; set; }
        /// <summary>
        /// Коэффициент
        /// </summary>
        public double? A { get; set; }
        /// <summary>
        /// Скорость ветра
        /// </summary>
        public double? Vh { get; set; }
        /// <summary>
        /// Тип выбросов
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Ответ
        /// </summary>
        public double Answer {get; set; }
    }
}
