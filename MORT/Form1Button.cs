﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MORT
{
    public partial class Form1
    {
     

        private void OnClick_GitHub(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/killkimno/MORT");
            }
            catch { }

        }
        private void OnClickopenBlog(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://blog.naver.com/killkimno/70179867557");
            }
            catch { }
        }

        private void OnClick_DebugOn(object sender, EventArgs e)
        {
            MySettingManager.isDebugMode = true;
            plDebugOff.Visible = false;
            plDebugOn.Visible = true;

        }



        private void Onclick_btSettingBrowser(object sender, EventArgs e)
        {
            FormManager.Instace.ShowSettingBrowserUI();
        }

        private void OnClick_btSettingUpload(object sender, EventArgs e)
        {
            var reader = Util.OpenFile(GlobalDefine.USER_SETTING_FILE);

            string data = reader.ReadToEnd();

            if(!string.IsNullOrEmpty(data))
            {
                try
                {
                    Clipboard.SetText(data);
                    string message = "현재 설정을 클립보드에 저장했습니다." + System.Environment.NewLine + "5번 항목에 클립보드 값을 ctrl+v로 붙여 넣으면 됩니다"
                                    + System.Environment.NewLine + System.Environment.NewLine + "확인을 누르면 업로드 페이지로 이동합니다";

                    //https://docs.google.com/forms/d/e/1FAIpQLSeHTcOQ_W_NXbt3lwf-osmLT_F0E1JwdTJjP7xYMGm_f41AEQ/viewform?usp=sf_link

                    if (DialogResult.OK == MessageBox.Show(message, "MORT", MessageBoxButtons.OK))
                    {
                        try
                        {
                            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/e/1FAIpQLSeHTcOQ_W_NXbt3lwf-osmLT_F0E1JwdTJjP7xYMGm_f41AEQ/viewform?usp=sf_link");
                        }
                        catch { }
                    }
                  
                }
                catch
                {

                }
            }
        }



        #region :::::::::: 체크 박스 ::::::::::

        private void cbUseTTS_CheckedChanged(object sender, EventArgs e)
        {
            if(cbUseTTS.Checked)
            {
            }
            else
            {
            }
        }


        #endregion


        #region :::::::::: 단축키 ::::::::::     


        private void transKeyInputResetButton_Click(object sender, EventArgs e)
        {
            InitTansKey();
        }

        private void dicKeyInputResetButton_Click(object sender, EventArgs e)
        {
            InitDicKey();
        }

        private void quickKeyInputResetButton_Click(object sender, EventArgs e)
        {
            InitQuickKey();
        }

        private void snapShotKeyInputResetButton_Click(object sender, EventArgs e)
        {
            InitSnapShotKey();
        }

        private void btnOneTransDefault_Click(object sender, EventArgs e)
        {
            InitOneTranslateKey();
        }


        private void btnHideTransDefault_Click(object sender, EventArgs e)
        {
            InitHideTransKey();
        }

        private void transKeyInputEmptyButton_Click(object sender, EventArgs e)
        {
            SetEmptyTansKey();
        }

        private void dicKeyInputEmptyButton_Click(object sender, EventArgs e)
        {
            SetEmptyDicKey();
        }

        private void quickKeyInputEmptyButton_Click(object sender, EventArgs e)
        {
            SetEmptyQuickKey();
        }

        private void snapShotKeyInputEmptyButton_Click(object sender, EventArgs e)
        {
            SetEmptySnapShotKey();
        }

        private void btnOneTransEmpty_Click(object sender, EventArgs e)
        {
            SetEmptyOneTranslate();
        }

        private void btnHideTransEmpty_Click(object sender, EventArgs e)
        {
            SetEmptyHideTranslate();
        }


        #endregion
    }
}
