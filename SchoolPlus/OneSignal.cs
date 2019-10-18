using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProPlus.ApiWeb.SchoolPlus.Dominio.Models
{
    public class OneSignal
    {
        public string ApplicationId { get; set; }
        public string Titulo { get; set; }
        public string Contexto { get; set; }
        public List<string> IdsNotifications { get; set; }
    }
}
