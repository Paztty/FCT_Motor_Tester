using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCT
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        Random random = new Random();
        List<string> Hello_Contens = new List<string>()
       {
        
            "☘ Chúc bạn một ngày làm việc vui vẻ....\n",
        
            "☘ Nếu cuộc đời ném vào mặt bạn một quả chanh, hãy vắt nước chanh thay vì chê nó chua quá...\n",
        
            "☘ Khi bạn không thể tìm thấy ánh nắng mặt trời, hãy là ánh nắng mặt trời.\n",
        
            "☘ Cuộc đời này thật ngắn ngủi, đừng dành… dù chỉ một phút cho những người, những việc khiến bạn buồn.\n",
        
            "☘ Người quan tâm đến tôi, tôi sẽ quan tâm lại gấp bội!\n",
        
            "☘ Có sinh sẽ có tử, song chỉ cần bạn vẫn đang có mặt trên đời này, thì phải sống bằng cách tốt nhất. Có thể không có tình yêu, không có đồ hàng hiệu, song không thể không vui vẻ.\n",
        
            "☘ Thứ không cần, có tốt đến đâu cũng là rác.\n",
        
            "☘ Nếu bạn không mù, thì đừng dùng tai để hiểu tôi.\n",
        
            "☘ Sự lợi hại thực sự không phải là bạn quen biết bao nhiêu người, mà là vào lúc bạn gặp hoạn nạn, có bao nhiêu người quen biết bạn.\n",
        
            "☘ Không nghe không hỏi không nhất định là đã quên, song chắc chắn là đã xa cách. Cả hai trầm lặng quá lâu, đến chủ động cũng cần có dũng khí.\n",
        
            "☘Đừng nên dùng những lời tuyệt tình để làm tổn thương đến người mà bạn yêu vào lúc tâm tình tồi tệ nhất.\n",
        
            "☘Có những lúc, không có lần sau, không có cơ hội bắt đầu lại. Có những lúc, bỏ lỡ hiện tại, vĩnh viễn không còn cơ hội nữa.\n",
        
            "☘Hãy dùng thái độ cam tâm tình nguyện để sống một cuộc sống an ổn.\n",
        
            "☘Tất thảy mọi vấn đề đều là vấn đề của bản thân.\n",
        
            "☘Đừng bao giờ thay đổi mình vì người khác. Nếu họ không thể tiếp nhận một con người nhiều điểm xấu là bạn, thì cũng không xứng để có được một con người với nhiều điểm tốt là bạn.\n",
        
            "☘Phụ nữ không có sức hấp dẫn mới cảm thấy đàn ông trăng hoa. Đàn ông không có thực lực mới cảm thấy phụ nữ thực dụng!\n",
        
            "☘Phụ nữ, không cần phải nghiêng nước nghiêng thành, chỉ cần một người đàn ông nghiêng về cô ấy cả một đời!\n",
        
            "☘Để tâm nên mới nghĩ ngợi linh tinh, không để tâm, đến nghĩ cũng chẳng buồn nghĩ!\n",
        
            "☘Khi con người ta vẫn còn trên đời, tưởng rằng còn nhiều thời gian, nhiều cơ hội. Thực ra cuộc đời là phép trừ, gặp nhau một lần, ít đi một lần.\n",
        
            "☘Thực ra, con người luôn ngược đời, người yêu bạn chiều chuộng bạn thì bạn không thèm. Người lạnh lùng, ơ hờ với bạn thì bạn lại theo đuổi mãi không thôi. Cuối cùng, người bị tổn thương đầy mình là chính bản thân bạn\n",
        
            "☘“Cuộc sống không phải là một vấn đề cần giải quyết, mà là thực tế để chúng ta cần trải nghiệm”\n",
        
            "☘“Điều quan trọng nhất để tận hưởng cuộc sống của chúng ta là hãy luôn hạnh phúc.”\n",
        
            "☘“Cuộc sống không phải là đi tìm con người thật của bạn. Cuộc sống tạo ra bản thân bạn.”\n",
        
            "☘Người đàn ông tình nguyện vì bạn mà theo đuổi mọi thứ chưa hẳn đã thật lòng yêu bạn, bởi vì thứ mà anh ta theo đuổi được không hẳn thuộc về bạn.\n",

            "☘Người đàn ông tình nguyện vì bạn mà từ bỏ tất cả mới là người thật tâm yêu bạn, bởi vì những thứ mà anh ta vứt bỏ đều là những thứ thiết thực nhất gắn liền với cuộc đời anh ta.\n",

            "☘Có lẽ cần phải trải qua tuổi thanh xuân mới có thể hiểu được tuổi xuân là khoảng thời gian ta sống ích kỷ biết chừng nào. Có lúc nghĩ, sở dĩ tình yêu cần phải đi một vòng tròn lớn như vậy, phải trả một cái giá quá đắt như thế, là bởi vì nó đến không đúng thời điểm. Khi có được tình yêu, chúng ta thiếu đi trí tuệ. Đợi đến khi có đủ trí tuệ, chúng ta đã không còn sức lực để yêu một tình yêu thuần khiết nữa.\n",

            "☘Cuộc sống không phải là phim ảnh, không có nhiều đến thế… những lần không hẹn mà gặp.\n",

            "☘Đôi khi, không cẩn thận biết một số chuyện, mới phát hiện ra rằng những điều bản thân để tâm lại nực cười đến thế.\n",

            "☘“Nếu bạn sống lâu, bạn sẽ mắc phải những sai lầm. Nhưng nếu bạn học được từ những sai lầm đó, bạn sẽ trở nên tốt hơn. Dù bạn đối phó với nghịch cảnh theo cách nào, điều không quan trọng. Điều quan trọng là bạn không bao giờ, không bao giờ, không bao giờ từ bỏ.”\n",
        
        };


        
        int hello_number;
        private void StartForm_Load(object sender, EventArgs e)
        {
            hello_number = random.Next(0, Hello_Contens.Count - 1);
            lbHello.Text = "";
            timerAnimation.Start();
            i = 0;
        }
        int i;
        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            if (i < Hello_Contens[hello_number].Length)
            {
                lbHello.Text += Hello_Contens[hello_number][i];
                if (Hello_Contens[hello_number][i] == '.')
                    timerAnimation.Interval = 100;
                else
                    timerAnimation.Interval = 5;
            }
            else
            {
                timerAnimation.Interval = Hello_Contens[hello_number].Length * 100;
            }

            if(timerAnimation.Interval == Hello_Contens[hello_number].Length * 100)
                this.DialogResult = DialogResult.OK;
            i++;
        }
    }
}
