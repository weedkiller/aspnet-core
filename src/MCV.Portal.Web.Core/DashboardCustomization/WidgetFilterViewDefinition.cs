﻿using System.Collections.Generic;
using Abp.Localization;

namespace MCV.Portal.Web.DashboardCustomization
{
    public class WidgetFilterViewDefinition : ViewDefinition
    {
        public WidgetFilterViewDefinition(
            string id,
            string viewFile,
            string javascriptFile = null,
            string cssFile = null) : base(id, viewFile, javascriptFile, cssFile)
        {

        }
    }
}