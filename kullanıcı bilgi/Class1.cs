using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kullanıcı_bilgi
{
        class BebekBilgileri
        {
            private string _ad;
 
            public string Ad
            {
                get { return _ad; }
                set 
                {
                    string ilkharf = value[0].ToString().ToUpper();
                    string geriKalan = value.Substring(1).ToLower();
                    _ad = ilkharf + geriKalan; 
                }
            }
            private string _soyad;
 
            public string Soyad
            {
                get { return _soyad; }
                set {_soyad = value.ToUpper(); }
            }
            private string _tc;
 
            public string Tc
            {
                get { return _tc; }
                set { _tc = value; }
            }
            private string _cinsiyet;
 
            public string Cinsiyet
            {
                get { return _cinsiyet; }
                set { _cinsiyet = value; }
            }
            private DateTime _dtarih;
 
            public DateTime Dtarih
            {
                get { return _dtarih; }
                set { _dtarih = value;}
            }
            public override string ToString()
            {
                return this.Ad + " " + this.Soyad;
 
            }
 
        }
}
