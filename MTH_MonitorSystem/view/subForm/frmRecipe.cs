using MTH_Models.models.Recipe;
using MTH_MonitorSystem.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.DataConvertLib;
using zj.MTHHelper;

namespace MTH_MonitorSystem
{
    public partial class frmRecipe : Form
    {
        #region 字段
        /// <summary>
        /// 保存配方的路径
        /// </summary>
        private string basePath = Application.StartupPath + "\\Recipe";
        private string devPath = string.Empty;
        private List<RecipeInfo > RecipeInfos= new List<RecipeInfo>();
        #endregion
        #region 构造函数
        public frmRecipe(string devPath)
        {
            InitializeComponent();
            this.lblCurrentRecipeName.Text =commonObj.Device .CurrentRecipe;
            this.txtRecipeName.Text = commonObj.Device.CurrentRecipe;
           
            this.devPath = devPath;
        }
        #endregion
        #region 方法
        #region 显示配方数据
        private void SetRecipeInfo(RecipeInfo info)
        {
            this.txtRecipeName.Text = info.RecipeName;
            if(info.RecipeParams .Count ==6)
            {
                this.recipeControl1.RecipParam = info.RecipeParams[0];
                this.recipeControl2.RecipParam = info.RecipeParams[1];
                this.recipeControl3.RecipParam = info.RecipeParams[2];
                this.recipeControl4.RecipParam = info.RecipeParams[3];
                this.recipeControl5.RecipParam = info.RecipeParams[4];
                this.recipeControl6.RecipParam = info.RecipeParams[5];
            }
            

        }
        #endregion
        #region 获取配方数据
        /// <summary>
        /// 获取当前的界面数据到配方数据
        /// </summary>
        /// <returns></returns>
        private RecipeInfo GetRecipeInfo()
        {
            RecipeInfo info = new RecipeInfo();
            info.RecipeName= txtRecipeName.Text.Trim();
            info.RecipeParams = new List<RecipeParam>
            {
                this.recipeControl1 .RecipParam,
                this.recipeControl2 .RecipParam,
                this.recipeControl3 .RecipParam,
                this.recipeControl4 .RecipParam,
                this.recipeControl5 .RecipParam,
                this.recipeControl6 .RecipParam
            };
            return info;
        }
        #endregion
        #region 添加配方的方法
        /// <summary>
        /// 添加配方文件
        /// </summary>
        /// <param name="recipeInfo"></param>
        /// <returns></returns>
        private bool AddRecipe(RecipeInfo recipeInfo)
        {
            //得到配方文件的路径
            string path = basePath + "\\" + recipeInfo.RecipeName + ".ini";
            return IniConfigHelper.WriteIniData("配方","配方数据",JSONHelper.EntityToJSON(recipeInfo),path);
        }
        #endregion
        #region 获取所有的配方
        /// <summary>
        /// 遍历配方文件，获取配方列表信息
        /// </summary>
        /// <returns></returns>
        private List<RecipeInfo> GetAllRecipeInfo()
        {
            //获取目录
            DirectoryInfo directoryInfo = new DirectoryInfo(basePath);
            //获取目录下的所有INI文件
            List<FileInfo> fileInfos =  directoryInfo.GetFiles("*.ini").ToList();
            List<RecipeInfo> recipeInfos= new List<RecipeInfo>();   
            //遍历所有的INI文件，转换为对象
            foreach (FileInfo fileInfo in fileInfos)
            {
                recipeInfos .Add(GetRecipeInfo(fileInfo.FullName));
            }
            return recipeInfos;

        }
        /// <summary>
        /// 通过JSON 文件路径获取配方信息对象
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private RecipeInfo GetRecipeInfo(string path)
        {
            return  JSONHelper.JSONToEntity<RecipeInfo>( IniConfigHelper.ReadIniData("配方", "配方数据", "", path));

        }
        #endregion
        #region 更新配方列表
        /// <summary>
        /// 通过配方文件获取配方列表，更新数据表
        /// </summary>
        private void RefreshRecipe()
        {
            RecipeInfos = GetAllRecipeInfo();
            dgvMain.Rows.Clear();
            if (RecipeInfos.Count > 0)
            {
               
                for(int i=0; i<RecipeInfos.Count; i++)
                {
                    this.dgvMain.Rows.Add();
                    this.dgvMain.Rows[i].Cells[0].Value=(i+1).ToString();
                    this.dgvMain.Rows[i].Cells[1].Value = RecipeInfos[i].RecipeName;
                    ///输入框中的的配方名对应的表格显示选中状态
                    if(this.txtRecipeName.Text.Trim() == RecipeInfos[i].RecipeName)
                    {
                        this.dgvMain.Rows[i].Selected= true;
                    }
                    else
                    {
                        this.dgvMain.Rows[i].Selected = false;
                    }
                }
                if (dgvMain.SelectedRows.Count > 0)
                {
                    SetRecipeInfo(this.RecipeInfos[dgvMain.SelectedRows[0].Index]);
                }

            }
        }
        #endregion
        #region 删除配方的方法
        private bool DelRecipe(string RecipeName)
        {
            try
            {
                File.Delete(basePath + "\\" + RecipeName + ".ini");
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion
        #endregion
        #region 事件
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            ///UI配方名称非空验证
            if(this.txtRecipeName.Text.Trim() .Length == 0)
            {
                new FrmMsgboxWithoutAck("配方名称为空，请检查！", "添加配方").Show();
                return;
            }
            ///验证要添加的配方名称不存在
            var info = RecipeInfos.Where(s=>s.RecipeName==this.txtRecipeName.Text .Trim ()).FirstOrDefault();
            if(info != null)
            {
                new FrmMsgboxWithoutAck("要添加的配方名称已存在，请检查！", "添加配方").Show();
                return;
            }
            ///获取UI上的配方设置
            RecipeInfo recipeInfo = GetRecipeInfo();
            ///添加配方到文件
            bool result = AddRecipe(recipeInfo);
            ///添加文件成功
            if(result)
            {
                ///读取所有配方更新界面
                RefreshRecipe();
                new FrmMsgboxWithoutAck("配方添加成功!","添加配方").Show ();
            }
            else
            {
                new FrmMsgboxWithoutAck("配方添加失败!", "添加配方").Show();
            }
        }

        private void btnModifyRecipe_Click(object sender, EventArgs e)
        {
            ///UI配方名称非空验证
            if (this.txtRecipeName.Text.Trim().Length == 0)
            {
                new FrmMsgboxWithoutAck("配方名称为空，请检查！", "修改配方").Show();
                return;
            }
            ///验证要修改的配方名称存在
            var info = RecipeInfos.Where(s => s.RecipeName == this.txtRecipeName.Text.Trim()).FirstOrDefault();
            if (info == null)
            {
                new FrmMsgboxWithoutAck("要修改的配方名称不存在，请检查！", "修改配方").Show();
                return;
            }
            ///获取UI上的配方设置
            RecipeInfo recipeInfo = GetRecipeInfo();
            ///添加配方到文件，文件已存在就覆盖
            bool result = AddRecipe(recipeInfo);
            //添加配方文件完成后，把所有配方显示在列表。
            if (result)
            {
                ///读取所有配方更新界面
                RefreshRecipe();
                new FrmMsgboxWithoutAck("配方修改成功!", "修改配方").Show();
            }
            else
            {
                new FrmMsgboxWithoutAck("配方修改失败!", "修改配方").Show();
            }
        }

        private void btnDelRecipe_Click(object sender, EventArgs e)
        {
            ///
            if (this.txtRecipeName.Text.Trim().Length == 0)
            {
                new FrmMsgboxWithoutAck("配方名称为空，请检查！", "删除配方").Show();
                return;
            }
            var info = RecipeInfos.Where(s => s.RecipeName == this.txtRecipeName.Text.Trim()).FirstOrDefault();
            
            if (info == null)
            {
                new FrmMsgboxWithoutAck("要删除的配方名称不存在，请检查！", "删除配方").Show();
                return;
            }

            DialogResult dialogResult = new FrmMsgboxWithAck("是否确定要删除配方？","删除配方").ShowDialog ();
            if(dialogResult == DialogResult.OK)
            {
                bool result = DelRecipe(this.txtRecipeName.Text.Trim());
                if (result)
                {
                    RefreshRecipe();
                    new FrmMsgboxWithoutAck("删除配方成功！","删除配方").Show();
                }
                else
                {
                    new FrmMsgboxWithoutAck("删除配方失败！", "删除配方").Show();
                }
            }
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                 RecipeInfo info = RecipeInfos[e.RowIndex];
                SetRecipeInfo(info);


            }
        }
        #endregion

        private void btnPresetRecipe_Click(object sender, EventArgs e)
        {
            ///
            if (this.txtRecipeName.Text.Trim().Length == 0)
            {
                new FrmMsgboxWithoutAck("配方名称为空，请检查！", "应用配方").Show();
                return;
            }
            var info = RecipeInfos.Where(s => s.RecipeName == this.txtRecipeName.Text.Trim()).FirstOrDefault();
            if (info == null)
            {
                new FrmMsgboxWithoutAck("要应用的配方名称不存在，请检查！", "应用配方").Show();
                return;
            }
            if(!commonObj.Device .IsConnected )
            {
                new FrmMsgboxWithoutAck("设备未连接，请检查！", "应用配方").Show();
                return;
            }

          
            if(info.RecipeParams.Count ==6)
            {
                List<short> values = new List<short>();
                //添加温度和湿度的高低限
                for(int i=0;i<6;i++)
                {
                    values.Add(Convert.ToInt16(info.RecipeParams[i].TempHighLimit * 10));
                    values.Add(Convert.ToInt16(info.RecipeParams[i].TempLowLimit * 10));
                    values.Add(Convert.ToInt16(info.RecipeParams[i].HumiHighLimit * 10));
                    values.Add(Convert.ToInt16(info.RecipeParams[i].HumiLowLimit * 10));
                }

                //添加空闲的地址，值为0
                for(int i = 0;i<24;i++)
                {
                    values.Add(0);
                }
                //添加报警启动位
                for (int i = 0; i < 6; i++)
                {
                    values.Add((short)(info.RecipeParams[i].TempAlarmEnable? 1:0));
                    values.Add((short)(info.RecipeParams[i].HumiAlarmEnable ? 1 : 0));
                }
                //写入到设备存储器
                bool result = commonObj.modbus.PreSetMultiRegisters(36, ByteArrayLib.GetByteArrayFromShortArray(values.ToArray(),commonObj.dataFormat));
                if (result)
                {
                    string recipeName = this.txtRecipeName.Text.Trim();

                    //把配方名写入当前配方
                    IniConfigHelper.WriteIniData("配方参数", "当前配方", recipeName, devPath);
                    commonObj .Device.CurrentRecipe= recipeName;
                    this.lblCurrentRecipeName.Text = recipeName;

                    new FrmMsgboxWithoutAck("配方数据写入成功！", "应用配方").Show();
                }
                else
                {
                    new FrmMsgboxWithoutAck("配方数据写入失败，请检查！", "应用配方").Show();
                    
                }
            }
            else
            {
                new FrmMsgboxWithoutAck("配方数据不完整，请检查！", "应用配方").Show();
            }
        }

        private void frmRecipe_Load(object sender, EventArgs e)
        {
            RefreshRecipe();
        }
    }
}
