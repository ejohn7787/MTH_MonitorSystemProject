using MTH_Models.device;
using MTH_Models.models.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thinger.DataConvertLib;
using zj.MTHHelper;

namespace MTH_MonitorSystem.common
{
    /// <summary>
    /// 公共对象和方法。
    /// </summary>
    public static class commonObj
    {
        /// <summary>
        /// 设定的大小端
        /// </summary>
        public static DataFormat dataFormat = DataFormat.ABCD;
        
        /// <summary>
        /// 静态的设备对象，可以在整个程序中共享数据
        /// </summary>
        public static Device Device { get; set; }
        /// <summary>
        /// 创建一个委托用于各个窗体添加日志到Monitor窗体,绑定位置 在frmMain窗体 line 407
        /// </summary>
        public static Action<int, string> Addlog;
        /// <summary>
        /// 静态的ModbusTCP对象
        /// </summary>
        public static ModbusTCP modbus { get; set; }
        /// <summary>
        /// 当前的登录用户
        /// </summary>
        public static SysAdmin CurrentAdmin { get; set; }
        /// <summary>
        /// 通过变量的名称找到变量对象
        /// </summary>
        /// <param name="varName">变量的名称</param>
        /// <returns></returns>
        private static Variable FindVariable(string varName)
        {
            foreach (Group group in Device.GroupList)
            {
                Variable variable =  group.VarList.Find (var=>var.VarName == varName);
                if(variable != null)
                {
                    return variable;
                }

            }
            return null;
        }
        /// <summary>
        /// 通用写入设备的方法
        /// </summary>
        /// <param name="varName">变量名称</param>
        /// <param name="varValue">变量值</param>
        /// <returns>写入是否成功</returns>
        public static bool CommonWrite(string varName,string varValue)
        {
            Variable variable= FindVariable(varName);
            //如果找到变量
            if (variable != null)
            {
                //获取变量
                //1、获取变量类型
                DataType dataType =(DataType)Enum.Parse(typeof(DataType), variable.DataType,true);
                //2、获取写入的的数据
                var result = MigrationLib.SetMigrationValue(varValue,dataType,variable.Scale.ToString(),variable.Offset.ToString());    
                //3、
                if(result.IsSuccess)
                {
                    try
                    {
                        //写入数据
                        switch (dataType)
                        {
                            case DataType.Bool:
                                return modbus.PreSetSingleCoil(variable.Start, Convert.ToBoolean(result.Content));

                            case DataType.Short:
                                return modbus.PreSetSingleRegister(variable.Start, Convert.ToInt16(result.Content));

                            case DataType.UShort:
                                return modbus.PreSetSingleRegister(variable.Start, Convert.ToUInt16(result.Content));

                            case DataType.Int:
                                return modbus.PreSetMultiRegisters(variable.Start, ByteArrayLib.GetByteArrayFromInt(Convert.ToInt32(result.Content), dataFormat));

                            case DataType.UInt:
                                return modbus.PreSetMultiRegisters(variable.Start, ByteArrayLib.GetByteArrayFromUInt(Convert.ToUInt32(result.Content), dataFormat));

                            case DataType.Float:
                                return modbus.PreSetMultiRegisters(variable.Start, ByteArrayLib.GetByteArrayFromFloat(Convert.ToSingle(result.Content), dataFormat));

                            case DataType.Double:
                                return modbus.PreSetMultiRegisters(variable.Start, ByteArrayLib.GetByteArrayFromDouble(Convert.ToDouble(result.Content), dataFormat));

                            case DataType.Long:
                                return modbus.PreSetMultiRegisters(variable.Start, ByteArrayLib.GetByteArrayFromLong(Convert.ToInt64(result.Content), dataFormat));

                            case DataType.ULong:
                                return modbus.PreSetMultiRegisters(variable.Start, ByteArrayLib.GetByteArrayFromULong(Convert.ToUInt64(result.Content), dataFormat));

                            case DataType.String:
                                return modbus.PreSetMultiRegisters(variable.Start, ByteArrayLib.GetByteArrayFromString(result.Content, Encoding.ASCII));

                            case DataType.ByteArray:
                                return modbus.PreSetMultiRegisters(variable.Start, ByteArrayLib.GetByteArrayFromHexString(result.Content));

                            case DataType.HexString:
                                return modbus.PreSetMultiRegisters(variable.Start, ByteArrayLib.GetByteArrayFromHexString(result.Content));

                            default:
                                break;
                        }
                    }
                    catch(Exception)
                    {
                        return false;
                    }
                    
                    
                }
                
               

            }
           
            //没有找到
            return false;
        }
    }
}
