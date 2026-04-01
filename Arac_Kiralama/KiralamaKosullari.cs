using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kiralama
{
    public partial class KiralamaKosullari : Form
    {
        public KiralamaKosullari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Kiraladığınız aracı yalnızca sözleşme ve teslimat formunda belirtilen kişi/kişiler kullanabilir. Sözleşmede belirtilmeyen üçüncü kişilerin, aracı kullanmaları halinde meydana gelebilecek hasarlarda, hiçbir hasar güvencesi geçerli değildir. Araç kullanıcı sayısını arttırabilmek için, “Ek Sürücü” hizmeti satın alabilirsiniz. Bir araç için en fazla 5 adet ek sürücü tanımlanabilir. Araç gruplarında belirlenmiş olan yaş ve ehliyet yılı koşulları dâhilinde kiralama yapılabilmektedir. Bu koşulların sağlanamaması durumunda “Genç Sürücü” hizmet paketi satın alarak bu paket içeriğindeki limitler dâhilinde kiralama yapabilirsiniz. Genç sürücü hizmet paketi “Süper Maksimum Güvence Plus” hizmetini de içermektedir. Rezervasyon aşamasında Ek Sürücü ve Genç Sürücü Hizmet ücretlerini görüntüleyebilirsiniz. Çağrı merkezimiz, ofislerimiz, web sitemiz ve mobil uygulamamızdan bu bilgilere ulaşabilirsiniz. ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Araç gruplarına bağlı minimum yaş ve ehliyet yılı bilgileri aşağıdaki tabloda belirtilmiştir. Bu koşulları hem kiracı hem de ek sürücünün/sürücülerin sağlaması gerekmektedir. Ehliyet üzerinde T.C. kimlik numarası bulunması zorunludur. Yeni kimliklerle birleşik ehliyetler ile kiralama yapılamaz. Yanınızda ehliyetiniz bulunmalıdır. Yabancı ehliyet ve pasaport ile kiralama yapabilirsiniz. Latin alfabesine sahip ehliyet ve pasaport ile kiralama yapılabilmektedir. Latin alfabesine sahip olmayan ehliyet ve pasaportunuz yeminli tercümana okutulmalı ve tercüme edilmiş belgenin aslının ofisimiz ile paylaşılması gerekmektedir. Ayrıca, pasaportunuzda bulunan ülkeye giriş gümrük damgası tarihi 6 aydan daha kısa olmalıdır.\r\n\r\n01.01.2016 tarihinden önce düzenlenen eski tip sürücü belgeleri, yasal düzenlemeye göre  31 Ekim 2025 itibarıyla geçersiz sayılacaktır. Bu tarihten sonra geçerliliğini yitirmiş sürücü belgeleri ile araç kiralama işlemi yapılamayacaktır. Kiralama işlemlerinde sorun yaşamamak için geçerli ve yeni tip bir sürücü belgesinin ibraz edilmesi gerekmektedir.\r\nKıbrıs Ercan Havalimanı ofisinden gerçekleştirilecek araç kiralamalarında, kiracıların minimum 25 yaşında olmaları gerekmektedir.";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Lütfen aracı teslim aldığınız yakıt seviyesi ile iade ediniz. Aracın eksik yakıt ile iade edilmesi durumunda, eksik olan yakıt bedeline ilave eksik yakıt bedelinin %40’ı kadar hizmet bedeli eklenerek tahsil edilecektir.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Ofise İade:\r\n\r\nAracınızı kiraladığınız ofisten farklı bir ofisimize iade etmek istediğinizde “Tek Yön” ücreti uygulanacaktır.\r\n\r\nTek Yön ücreti aynı şehir içerisinde, alınan ofisten farklı bir ofise iade ettiğinizde de uygulanır.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Trafik kurallarına uyulmaması sonucu ortaya çıkacak her tür trafik cezasının (köprü ve otoyollarda hatalı gişe kullanılması da dâhil olmak üzere) ödemesi ve hizmet bedeli sözleşmede ismi geçen kiracıya ait kredi kartından yapılacaktır.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Sözleşmede yer alan kiralama süresinden bağımsız olarak, toplam kullanılan kilometre miktarı ilgili araç grubunun aylık kilometre limitiyle sınırlıdır. Rezervasyon esnasında Ek Ürünler alanından ek kilometre paketleri satın alınarak KM limiti artırılabilmektedir. Kiralama başladıktan sonra ek kilometre paketi satın alınamaz. Günlük belirlenen KM limitinin, aylık belirlenen KM limitini aşması durumunda;";
        }
    }
}
