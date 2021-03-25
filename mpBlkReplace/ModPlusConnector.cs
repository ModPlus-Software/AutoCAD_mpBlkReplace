namespace mpBlkReplace
{
    using System;
    using System.Collections.Generic;
    using ModPlusAPI.Abstractions;
    using ModPlusAPI.Enums;

    /// <inheritdoc/>
    public class ModPlusConnector : IModPlusPlugin
    {
        /// <inheritdoc/>
        public SupportedProduct SupportedProduct => SupportedProduct.AutoCAD;

        /// <inheritdoc/>
        public string Name => "mpBlkReplace";

#if A2013
        /// <inheritdoc/>
        public string AvailProductExternalVersion => "2013";
#elif A2014
        /// <inheritdoc/>
        public string AvailProductExternalVersion => "2014";
#elif A2015
        /// <inheritdoc/>
        public string AvailProductExternalVersion => "2015";
#elif A2016
        /// <inheritdoc/>
        public string AvailProductExternalVersion => "2016";
#elif A2017
        /// <inheritdoc/>
        public string AvailProductExternalVersion => "2017";
#elif A2018
        /// <inheritdoc/>
        public string AvailProductExternalVersion => "2018";
#elif A2019
        /// <inheritdoc/>
        public string AvailProductExternalVersion => "2019";
#elif A2020
        /// <inheritdoc/>
        public string AvailProductExternalVersion => "2020";
#elif A2021
        /// <inheritdoc/>
        public string AvailProductExternalVersion => "2021";
#elif A2022
        /// <inheritdoc/>
        public string AvailProductExternalVersion => "2022";
#endif

        /// <inheritdoc/>
        public string FullClassName => string.Empty;

        /// <inheritdoc/>
        public string AppFullClassName => string.Empty;

        /// <inheritdoc/>
        public Guid AddInId => Guid.Empty;

        /// <inheritdoc/>
        public string LName => "Замена блоков";

        /// <inheritdoc/>
        public string Description => "Плагин позволяет производить быструю замену блоков в чертеже на блок-образчик";

        /// <inheritdoc/>
        public string Author => "Пекшев Александр aka Modis";

        /// <inheritdoc/>
        public string Price => "0";

        /// <inheritdoc/>
        public bool CanAddToRibbon => true;

        /// <inheritdoc/>
        public string FullDescription => "Плагин работает в двух режимах: Заменить выбранные - позволяет заменить все выбранные блоки на один блок-образчик; Заменить подобные - позволяет заменить все вхождения одного блока на один блок-образчик. Позволяет удалить описание замененного блока из базы чертежа. По аналогии с командой \"Очистить\" (_PURGE). Присутствуют различные настройки.";

        /// <inheritdoc/>
        public string ToolTipHelpImage => string.Empty;

        /// <inheritdoc/>
        public List<string> SubPluginsNames => new List<string>();

        /// <inheritdoc/>
        public List<string> SubPluginsLNames => new List<string>();

        /// <inheritdoc/>
        public List<string> SubDescriptions => new List<string>();

        /// <inheritdoc/>
        public List<string> SubFullDescriptions => new List<string>();

        /// <inheritdoc/>
        public List<string> SubHelpImages => new List<string>();

        /// <inheritdoc/>
        public List<string> SubClassNames => new List<string>();
    }
}