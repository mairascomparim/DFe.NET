﻿using System;
using System.Xml.Serialization;

namespace ManifestoDocumentoFiscalEletronico.Classes
{
    [Serializable]
    public class MDFeAutXML
    {
        [XmlElement(ElementName = "CNPJ")]
        public string CNPJ { get; set; }

        [XmlElement(ElementName = "CPF")]
        public string CPF { get; set; }
    }
}