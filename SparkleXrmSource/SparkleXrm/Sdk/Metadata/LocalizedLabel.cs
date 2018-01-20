﻿using System.Runtime.CompilerServices;
using System.Xml;
using Xrm.Sdk;
using Xrm.Sdk.Metadata;

namespace SparkleXrm.Sdk.Metadata.Query
{
   
    public static partial class MetadataSerialiser
    {
        public static LocalizedLabel DeSerialiseLocalizedLabel(LocalizedLabel item, XmlNode metaData)
        {
            item.Label = XmlHelper.SelectSingleNodeValue(metaData, "Label");
            item.LanguageCode = int.Parse(XmlHelper.SelectSingleNodeValue(metaData, "LanguageCode"));
            return item;
        }
    }
}
namespace Xrm.Sdk.Metadata
{
    [Imported]
    [IgnoreNamespace]
    [ScriptName("Object")]
    public class LocalizedLabel
    {
        [PreserveCase]
        public string Label;
        [PreserveCase]
        public int LanguageCode;
        
    }
}
