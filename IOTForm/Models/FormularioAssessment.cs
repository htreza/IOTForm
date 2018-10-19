using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOTForm.Models
{
    public class FormularioAssessment
    {
        public readonly AmbienteProjeto AmbienteProjeto;
        public readonly AtivosDevices AtivosDevices;
        public readonly PadroesRequerimentos PadroesRequerimentos;
        public readonly ServicosBackend ServicosBackend;

        public FormularioAssessment(AmbienteProjeto AmbienteProjeto, AtivosDevices AtivosDevices, PadroesRequerimentos PadroesRequerimentos, ServicosBackend ServicosBackend)
        {
            this.AmbienteProjeto = AmbienteProjeto;
            this.AtivosDevices = AtivosDevices;
            this.PadroesRequerimentos = PadroesRequerimentos;
            this.ServicosBackend = ServicosBackend;
        }
    }
}