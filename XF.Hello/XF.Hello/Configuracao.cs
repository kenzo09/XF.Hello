using System;
using System.Collections.Generic;
using System.Text;

namespace XF.Hello
{
    public class Configuracao
    {
        public bool Localizacao { get; set; }
        public bool Cookies { get; set; }
        public bool Mural { get; set; }
        public bool Email { get; set; }
        public bool SMS { get; set; }

        private static Configuracao _configuracao;
        public static Configuracao CreateInstance()
        {
            if(_configuracao == null)
                _configuracao = new Configuracao();

            return _configuracao;
        }
    }
}
