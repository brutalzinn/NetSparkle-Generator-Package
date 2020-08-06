using System;
using System.Collections.Generic;
using System.Text;
using Update.Maker.Forms;

namespace Update.Maker.Source_files
{

   

     public class Globals
    {

        public static string nome_arquivo = "update.survivalcrafters";
        public static string application_name = "GeradorUpdate1.0";
        public static int? contagem_files = 0;
        public static principal principal;
        public static Formulario formulario;
        public static string url = "robertinho.net";
        public enum ByForm
        {
            none,
            principal,
            serialActivation

        }
        public enum code
        {
            erro,
            grave,
            aviso,
            importante,
            GERENCIADOR




        }

    }
}
