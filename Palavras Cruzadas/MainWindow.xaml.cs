using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Palavras_Cruzadas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            VocêVenceutxt.Visibility = Visibility.Hidden;
        }

        string Palavra_1 = "";
        string Palavra_2 = "";
        string Palavra_3 = "";
        string Palavra_4 = "";
        string Palavra_5 = "";
        string Palavra_6 = "";
        string Palavra_7 = "";
        string Palavra_8 = "";
        string Palavra_9 = "";
        string Palavra_10 = "";

        int MaisAcerto = 0;

        private void ApareceDica1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Sentido pelo qual se percebem e se distinguem os odores.");
        }

        private void ApareceDica2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Pôr à disposição; ceder temporariamente.");
        }

        private void ApareceDica3(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Lugar, boxe ou guichê onde se vendem bilhetes para entrada em espetáculos públicos, passagens para usuários de transportes.");
        }

        private void ApareceDica4(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Que é excessivamente insistente; birrento, obstinado, persistente.");
        }

        private void ApareceDica5(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Aplicar as capacidades intelectuais para adquirir conhecimento e habilidade.");
        }

        private void ApareceDica6(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Dar, entregar, comutar alguma coisa ou pessoa por algo ou alguém.");
        }

        private void ApareceDica7(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Difícil de cortar, dobrar, partir, penetrar ou riscar; resistente, sólido.");
        }

        private void ApareceDica8(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Abertura inicial do tubo digestivo dos animais.");
        }

        private void ApareceDica9(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Trocar ideias ou se comunicar com alguém por meio de palavras.");
        }

        private void ApareceDica10(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Pequeno vaso para beber, feito de vários materiais, sem asa e de forma cilíndrica.");
        }

        private void InserirPalavra(object sender, KeyEventArgs e)
        {

            // Verifica Palavra 1
            Palavra_1 = txt1_O.Text + txt1I3_L.Text + txt1_F.Text + txt1_A.Text + txt1I2_T.Text + txt1_O1.Text;
            Palavra_1 = Palavra_1.ToUpper();

            if (Palavra_1.Contains("OLFATO"))
            {
                if (txt1_O1.Background != Brushes.Green)
                {
                    txt1_O.Background = Brushes.Green;
                    txt1I3_L.Background = Brushes.Green;
                    txt1_F.Background = Brushes.Green;
                    txt1_A.Background = Brushes.Green;
                    txt1I2_T.Background = Brushes.Green;
                    txt1_O1.Background = Brushes.Green;

                    txt1_O.IsHitTestVisible = false;
                    txt1I3_L.IsHitTestVisible = false;
                    txt1_F.IsHitTestVisible = false;
                    txt1_A.IsHitTestVisible = false;
                    txt1I2_T.IsHitTestVisible = false;
                    txt1_O1.IsHitTestVisible = false;
                    MaisAcerto++;
                }
                else
                {
                    Palavra_1 = "OLFATO";
                }
            }

            //Verifica palavra 2
            Palavra_2 = txt2I5_E.Text + txt2IM.Text + txt2I10_P.Text + txt2IR.Text + txt2I4_E.Text + txt2IS.Text + txt1I2_T.Text + txt2_A.Text + txt2I6_R.Text;
            Palavra_2 = Palavra_2.ToUpper();

            if (Palavra_2.Contains("EMPRESTAR"))
            {
                if (txt2IM.Background != Brushes.Green)
                {
                    txt2I5_E.Background = Brushes.Green;
                    txt2IM.Background = Brushes.Green;
                    txt2I10_P.Background = Brushes.Green;
                    txt2IR.Background = Brushes.Green;
                    txt2I4_E.Background = Brushes.Green;
                    txt2IS.Background = Brushes.Green;
                    txt1I2_T.Background = Brushes.Green;
                    txt2_A.Background = Brushes.Green;
                    txt2I6_R.Background = Brushes.Green;

                    txt2I5_E.IsHitTestVisible = false;
                    txt2IM.IsHitTestVisible = false;
                    txt2I10_P.IsHitTestVisible = false;
                    txt2IR.IsHitTestVisible = false;
                    txt2I4_E.IsHitTestVisible = false;
                    txt2IS.IsHitTestVisible = false;
                    txt1I2_T.IsHitTestVisible = false;
                    txt2_A.IsHitTestVisible = false;
                    txt2I6_R.IsHitTestVisible = false;
                    MaisAcerto++;
                }
                else
                {
                    Palavra_2 = "EMPRESTAR";
                }
            }

            //Verifica Palavra 3
            Palavra_3 = txt3_B.Text + txt3_I.Text + txt1I3_L.Text + txt3_H.Text + txt3_E.Text + txt3_T.Text + txt3I9_E.Text + txt3_R.Text + txt3_I1.Text + txt3_A.Text;
            Palavra_3 = Palavra_3.ToUpper();

            if (Palavra_3.Contains("BILHETERIA"))
            {
                if (txt3_B.Background != Brushes.Green)
                {
                    txt3_B.Background = Brushes.Green;
                    txt3_I.Background = Brushes.Green;
                    txt1I3_L.Background = Brushes.Green;
                    txt3_H.Background = Brushes.Green;
                    txt3_E.Background = Brushes.Green;
                    txt3_T.Background = Brushes.Green;
                    txt3I9_E.Background = Brushes.Green;
                    txt3_R.Background = Brushes.Green;
                    txt3_I1.Background = Brushes.Green;
                    txt3_A.Background = Brushes.Green;

                    txt3_B.IsHitTestVisible = false;
                    txt3_I.IsHitTestVisible = false;
                    txt1I3_L.IsHitTestVisible = false;
                    txt3_H.IsHitTestVisible = false;
                    txt3_E.IsHitTestVisible = false;
                    txt3_T.IsHitTestVisible = false;
                    txt3I9_E.IsHitTestVisible = false;
                    txt3_R.IsHitTestVisible = false;
                    txt3_I1.IsHitTestVisible = false;
                    txt3_A.IsHitTestVisible = false;
                    MaisAcerto++;
                }
                else
                {
                    Palavra_3 = "BILHETERIA";
                }
            }

            //Verifica Palavra 4
            Palavra_4 = txt4_T.Text + txt2I4_E.Text + txt4_I.Text + txt4_M.Text + txt4_O.Text + txt4_S.Text + txt4I8_O.Text;
            Palavra_4 = Palavra_4.ToUpper();

            if (Palavra_4.Contains("TEIMOSO"))
            {
                if (txt4_T.Background != Brushes.Green)
                {
                    txt4_T.Background = Brushes.Green;
                    txt2I4_E.Background = Brushes.Green;
                    txt4_I.Background = Brushes.Green;
                    txt4_M.Background = Brushes.Green;
                    txt4_O.Background = Brushes.Green;
                    txt4_S.Background = Brushes.Green;
                    txt4I8_O.Background = Brushes.Green;

                    txt4_T.IsHitTestVisible = false;
                    txt2I4_E.IsHitTestVisible = false;
                    txt4_I.IsHitTestVisible = false;
                    txt4_M.IsHitTestVisible = false;
                    txt4_O.IsHitTestVisible = false;
                    txt4_S.IsHitTestVisible = false;
                    txt4I8_O.IsHitTestVisible = false;
                    MaisAcerto++;
                }
                else
                {
                    Palavra_4 = "TEIMOSO";
                }
            }

            //Verifica Palavra 5
            Palavra_5 = txt2I5_E.Text + txt5_S.Text + txt5_T.Text + txt5I7_U.Text + txt5_D.Text + txt5_A.Text + txt5_R.Text;
            Palavra_5 = Palavra_5.ToUpper();

            if (Palavra_5.Contains("ESTUDAR"))
            {
                if (txt5_A.Background != Brushes.Green)
                {
                    txt2I5_E.Background = Brushes.Green;
                    txt5_S.Background = Brushes.Green;
                    txt5_T.Background = Brushes.Green;
                    txt5I7_U.Background = Brushes.Green;
                    txt5_D.Background = Brushes.Green;
                    txt5_A.Background = Brushes.Green;
                    txt5_R.Background = Brushes.Green;

                    txt2I5_E.IsHitTestVisible = false;
                    txt5_S.IsHitTestVisible = false;
                    txt5_T.IsHitTestVisible = false;
                    txt5I7_U.IsHitTestVisible = false;
                    txt5_D.IsHitTestVisible = false;
                    txt5_A.IsHitTestVisible = false;
                    txt5_R.IsHitTestVisible = false;
                    MaisAcerto++;
                }
                else
                {
                    Palavra_5 = "ESTUDAR";
                }
            }

            //Verifica Palavra 6
            Palavra_6 = txt6_T.Text + txt2I6_R.Text + txt6_O.Text + txt6_C.Text + txt6_A.Text + txt6_R.Text;
            Palavra_6 = Palavra_6.ToUpper();

            if (Palavra_6.Contains("TROCAR"))
            {
                if (txt6_T.Background != Brushes.Green)
                {
                    txt6_T.Background = Brushes.Green;
                    txt2I6_R.Background = Brushes.Green;
                    txt6_O.Background = Brushes.Green;
                    txt6_C.Background = Brushes.Green;
                    txt6_A.Background = Brushes.Green;
                    txt6_R.Background = Brushes.Green;

                    txt6_T.IsHitTestVisible = false;
                    txt2I6_R.IsHitTestVisible = false;
                    txt6_O.IsHitTestVisible = false;
                    txt6_C.IsHitTestVisible = false;
                    txt6_A.IsHitTestVisible = false;
                    txt6_R.IsHitTestVisible = false;
                    MaisAcerto++;
                }
                else
                {
                    Palavra_6 = "TROCAR";
                }
            }

            //Verifica Palavra 7
            Palavra_7 = txt7_D.Text + txt5I7_U.Text + txt7_R.Text + txt7_O.Text;
            Palavra_7 = Palavra_7.ToUpper();

            if (Palavra_7.Contains("DURO"))
            {
                if (txt7_O.Background != Brushes.Green)
                {
                    txt7_D.Background = Brushes.Green;
                    txt5I7_U.Background = Brushes.Green;
                    txt7_R.Background = Brushes.Green;
                    txt7_O.Background = Brushes.Green;

                    txt7_D.IsHitTestVisible = false;
                    txt5I7_U.IsHitTestVisible = false;
                    txt7_R.IsHitTestVisible = false;
                    txt7_O.IsHitTestVisible = false;
                    MaisAcerto++;
                }
                else
                {
                    Palavra_7 = "DURO";
                }
            }

            //Verifica Palavra 8
            Palavra_8 = txt8_B.Text + txt4I8_O.Text + txt8_C.Text + txt8_A.Text;
            Palavra_8 = Palavra_8.ToUpper();

            if (Palavra_8.Contains("BOCA"))
            {
                if (txt8_C.Background != Brushes.Green)
                {
                    txt8_B.Background = Brushes.Green;
                    txt4I8_O.Background = Brushes.Green;
                    txt8_C.Background = Brushes.Green;
                    txt8_A.Background = Brushes.Green;

                    txt8_B.IsHitTestVisible = false;
                    txt4I8_O.IsHitTestVisible = false;
                    txt8_C.IsHitTestVisible = false;
                    txt8_A.IsHitTestVisible = false;
                    MaisAcerto++;
                }
                else
                {
                    Palavra_8 = "BOCA";
                }
            }

            //Verifica Palavra 9
            Palavra_9 = txt9_C.Text + txt9_O.Text + txt9_N.Text + txt9_V.Text + txt3I9_E.Text + txt9_R.Text + txt9_S.Text + txt9_A.Text + txt9_R1.Text;
            Palavra_9 = Palavra_9.ToUpper();

            if (Palavra_9.Contains("CONVERSAR"))
            {
                if (txt9_C.Background != Brushes.Green)
                {
                    txt9_C.Background = Brushes.Green;
                    txt9_O.Background = Brushes.Green;
                    txt9_N.Background = Brushes.Green;
                    txt9_V.Background = Brushes.Green;
                    txt3I9_E.Background = Brushes.Green;
                    txt9_R.Background = Brushes.Green;
                    txt9_S.Background = Brushes.Green;
                    txt9_A.Background = Brushes.Green;
                    txt9_R1.Background = Brushes.Green;

                    txt9_C.IsHitTestVisible = false;
                    txt9_O.IsHitTestVisible = false;
                    txt9_N.IsHitTestVisible = false;
                    txt9_V.IsHitTestVisible = false;
                    txt3I9_E.IsHitTestVisible = false;
                    txt9_R.IsHitTestVisible = false;
                    txt9_S.IsHitTestVisible = false;
                    txt9_A.IsHitTestVisible = false;
                    txt9_R1.IsHitTestVisible = false;

                    MaisAcerto++;
                }
                else
                {
                    Palavra_9 = "CONVERSAR";
                }
            }

            //Verifica Palavra 10
            Palavra_10 = txt10_C.Text + txt10_O.Text + txt2I10_P.Text + txt10_O1.Text;
            Palavra_10 = Palavra_10.ToUpper();

            if (Palavra_10.Contains("COPO"))
            {
                if (txt10_C.Background != Brushes.Green)
                {
                    txt10_C.Background = Brushes.Green;
                    txt10_O.Background = Brushes.Green;
                    txt2I10_P.Background = Brushes.Green;
                    txt10_O1.Background = Brushes.Green;

                    txt10_C.IsHitTestVisible = false;
                    txt10_O.IsHitTestVisible = false;
                    txt2I10_P.IsHitTestVisible = false;
                    txt10_O1.IsHitTestVisible = false;

                    MaisAcerto++;
                }
                else
                {
                    Palavra_10 = "COPO";
                }
            }

            if(MaisAcerto == 10)
            {
                VocêVenceutxt.Visibility = Visibility.Visible;
            }
        }
    }
}
