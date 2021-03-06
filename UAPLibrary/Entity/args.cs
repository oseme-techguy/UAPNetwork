﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由梁爽制作的工具于【2010-03-15 03:33:13】生成。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UAPLibrary.Utility;
using UAPLibrary.Entity;

namespace UAPLibrary.Packet
{
    #region UapBindEvent:请求连接
    /// <summary>
    /// 请求连接事件的委托
    /// </summary>
    /// <param name="source">事件源</param>
    /// <param name="e">请求连接事件参数</param>
    public delegate void UapBindEventHandler(object source, UapBindEventArgs e);

    /// <summary>
    /// 请求连接事件参数
    /// </summary>
    public class UapBindEventArgs : UapEventArgs
    {
        private UapBind _response;

        /// <summary>
        /// 访问请求连接事件源的数据
        /// </summary>
        public UapBind BindUap
        {
            get
            {
                return _response;
            }
        }

        /// <summary>
        /// 创建请求连接事件参数
        /// </summary>
        /// <param name="response">UapBind包</param>
        public UapBindEventArgs(UapBind response)
            : base(response)
        {
            _response = response;
        }
    }

    #endregion UapBindEvent:请求连接

    #region UapBindRespEvent:请求连接应答
    /// <summary>
    /// 请求连接应答事件的委托
    /// </summary>
    /// <param name="source">事件源</param>
    /// <param name="e">请求连接应答事件参数</param>
    public delegate void UapBindRespEventHandler(object source, UapBindRespEventArgs e);

    /// <summary>
    /// 请求连接应答事件参数
    /// </summary>
    public class UapBindRespEventArgs : UapEventArgs
    {
        private UapBindResp _response;

        /// <summary>
        /// 访问请求连接应答事件源的数据
        /// </summary>
        public UapBindResp BindRespUap
        {
            get
            {
                return _response;
            }
        }

        /// <summary>
        /// 创建请求连接应答事件参数
        /// </summary>
        /// <param name="response">UapBindResp包</param>
        public UapBindRespEventArgs(UapBindResp response)
            : base(response)
        {
            _response = response;
        }
    }

    #endregion UapBindRespEvent:请求连接应答

    #region UapUnbindEvent:终止连接
    /// <summary>
    /// 终止连接事件的委托
    /// </summary>
    /// <param name="source">事件源</param>
    /// <param name="e">终止连接事件参数</param>
    public delegate void UapUnbindEventHandler(object source, UapUnbindEventArgs e);

    /// <summary>
    /// 终止连接事件参数
    /// </summary>
    public class UapUnbindEventArgs : UapEventArgs
    {
        private UapUnbind _response;

        /// <summary>
        /// 访问终止连接事件源的数据
        /// </summary>
        public UapUnbind UnbindUap
        {
            get
            {
                return _response;
            }
        }

        /// <summary>
        /// 创建终止连接事件参数
        /// </summary>
        /// <param name="response">UapUnbind包</param>
        public UapUnbindEventArgs(UapUnbind response)
            : base(response)
        {
            _response = response;
        }
    }

    #endregion UapUnbindEvent:终止连接

    #region UapUnbindRespEvent:终止连接应答
    /// <summary>
    /// 终止连接应答事件的委托
    /// </summary>
    /// <param name="source">事件源</param>
    /// <param name="e">终止连接应答事件参数</param>
    public delegate void UapUnbindRespEventHandler(object source, UapUnbindRespEventArgs e);

    /// <summary>
    /// 终止连接应答事件参数
    /// </summary>
    public class UapUnbindRespEventArgs : UapEventArgs
    {
        private UapUnbindResp _response;

        /// <summary>
        /// 访问终止连接应答事件源的数据
        /// </summary>
        public UapUnbindResp UnbindRespUap
        {
            get
            {
                return _response;
            }
        }

        /// <summary>
        /// 创建终止连接应答事件参数
        /// </summary>
        /// <param name="response">UapUnbindResp包</param>
        public UapUnbindRespEventArgs(UapUnbindResp response)
            : base(response)
        {
            _response = response;
        }
    }

    #endregion UapUnbindRespEvent:终止连接应答

    #region UapEnquireLinkEvent:握手请求
    /// <summary>
    /// 握手请求事件的委托
    /// </summary>
    /// <param name="source">事件源</param>
    /// <param name="e">握手请求事件参数</param>
    public delegate void UapEnquireLinkEventHandler(object source, UapEnquireLinkEventArgs e);

    /// <summary>
    /// 握手请求事件参数
    /// </summary>
    public class UapEnquireLinkEventArgs : UapEventArgs
    {
        private UapEnquireLink _response;

        /// <summary>
        /// 访问握手请求事件源的数据
        /// </summary>
        public UapEnquireLink EnquireLinkUap
        {
            get
            {
                return _response;
            }
        }

        /// <summary>
        /// 创建握手请求事件参数
        /// </summary>
        /// <param name="response">UapEnquireLink包</param>
        public UapEnquireLinkEventArgs(UapEnquireLink response)
            : base(response)
        {
            _response = response;
        }
    }

    #endregion UapEnquireLinkEvent:握手请求

    #region UapEnquireLinkRespEvent:握手应答
    /// <summary>
    /// 握手应答事件的委托
    /// </summary>
    /// <param name="source">事件源</param>
    /// <param name="e">握手应答事件参数</param>
    public delegate void UapEnquireLinkRespEventHandler(object source, UapEnquireLinkRespEventArgs e);

    /// <summary>
    /// 握手应答事件参数
    /// </summary>
    public class UapEnquireLinkRespEventArgs : UapEventArgs
    {
        private UapEnquireLinkResp _response;

        /// <summary>
        /// 访问握手应答事件源的数据
        /// </summary>
        public UapEnquireLinkResp EnquireLinkRespUap
        {
            get
            {
                return _response;
            }
        }

        /// <summary>
        /// 创建握手应答事件参数
        /// </summary>
        /// <param name="response">UapEnquireLinkResp包</param>
        public UapEnquireLinkRespEventArgs(UapEnquireLinkResp response)
            : base(response)
        {
            _response = response;
        }
    }

    #endregion UapEnquireLinkRespEvent:握手应答

    #region UapBeginEvent:开始USSD会话
    /// <summary>
    /// 开始USSD会话事件的委托
    /// </summary>
    /// <param name="source">事件源</param>
    /// <param name="e">开始USSD会话事件参数</param>
    public delegate void UapBeginEventHandler(object source, UapBeginEventArgs e);

    /// <summary>
    /// 开始USSD会话事件参数
    /// </summary>
    public class UapBeginEventArgs : UapEventArgs
    {
        private UapBegin _response;

        /// <summary>
        /// 访问开始USSD会话事件源的数据
        /// </summary>
        public UapBegin BeginUap
        {
            get
            {
                return _response;
            }
        }

        /// <summary>
        /// 创建开始USSD会话事件参数
        /// </summary>
        /// <param name="response">UapBegin包</param>
        public UapBeginEventArgs(UapBegin response)
            : base(response)
        {
            _response = response;
        }
    }

    #endregion UapBeginEvent:开始USSD会话

    #region UapContinueEvent:继续USSD会话
    /// <summary>
    /// 继续USSD会话事件的委托
    /// </summary>
    /// <param name="source">事件源</param>
    /// <param name="e">继续USSD会话事件参数</param>
    public delegate void UapContinueEventHandler(object source, UapContinueEventArgs e);

    /// <summary>
    /// 继续USSD会话事件参数
    /// </summary>
    public class UapContinueEventArgs : UapEventArgs
    {
        private UapContinue _response;

        /// <summary>
        /// 访问继续USSD会话事件源的数据
        /// </summary>
        public UapContinue ContinueUap
        {
            get
            {
                return _response;
            }
        }

        /// <summary>
        /// 创建继续USSD会话事件参数
        /// </summary>
        /// <param name="response">UapContinue包</param>
        public UapContinueEventArgs(UapContinue response)
            : base(response)
        {
            _response = response;
        }
    }

    #endregion UapContinueEvent:继续USSD会话

    #region UapEndEvent:结束USSD会话
    /// <summary>
    /// 结束USSD会话事件的委托
    /// </summary>
    /// <param name="source">事件源</param>
    /// <param name="e">结束USSD会话事件参数</param>
    public delegate void UapEndEventHandler(object source, UapEndEventArgs e);

    /// <summary>
    /// 结束USSD会话事件参数
    /// </summary>
    public class UapEndEventArgs : UapEventArgs
    {
        private UapEnd _response;

        /// <summary>
        /// 访问结束USSD会话事件源的数据
        /// </summary>
        public UapEnd EndUap
        {
            get
            {
                return _response;
            }
        }

        /// <summary>
        /// 创建结束USSD会话事件参数
        /// </summary>
        /// <param name="response">UapEnd包</param>
        public UapEndEventArgs(UapEnd response)
            : base(response)
        {
            _response = response;
        }
    }

    #endregion UapEndEvent:结束USSD会话

    #region UapAbortEvent:中止USSD会话
    /// <summary>
    /// 中止USSD会话事件的委托
    /// </summary>
    /// <param name="source">事件源</param>
    /// <param name="e">中止USSD会话事件参数</param>
    public delegate void UapAbortEventHandler(object source, UapAbortEventArgs e);

    /// <summary>
    /// 中止USSD会话事件参数
    /// </summary>
    public class UapAbortEventArgs : UapEventArgs
    {
        private UapAbort _response;

        /// <summary>
        /// 访问中止USSD会话事件源的数据
        /// </summary>
        public UapAbort AbortUap
        {
            get
            {
                return _response;
            }
        }

        /// <summary>
        /// 创建中止USSD会话事件参数
        /// </summary>
        /// <param name="response">UapAbort包</param>
        public UapAbortEventArgs(UapAbort response)
            : base(response)
        {
            _response = response;
        }
    }

    #endregion UapAbortEvent:中止USSD会话

    #region UapSwitchEvent:USSD会话转移
    /// <summary>
    /// USSD会话转移事件的委托
    /// </summary>
    /// <param name="source">事件源</param>
    /// <param name="e">USSD会话转移事件参数</param>
    public delegate void UapSwitchEventHandler(object source, UapSwitchEventArgs e);

    /// <summary>
    /// USSD会话转移事件参数
    /// </summary>
    public class UapSwitchEventArgs : UapEventArgs
    {
        private UapSwitch _response;

        /// <summary>
        /// 访问USSD会话转移事件源的数据
        /// </summary>
        public UapSwitch SwitchUap
        {
            get
            {
                return _response;
            }
        }

        /// <summary>
        /// 创建USSD会话转移事件参数
        /// </summary>
        /// <param name="response">UapSwitch包</param>
        public UapSwitchEventArgs(UapSwitch response)
            : base(response)
        {
            _response = response;
        }
    }

    #endregion UapSwitchEvent:USSD会话转移

    #region UapChargeindEvent:计费指示
    /// <summary>
    /// 计费指示事件的委托
    /// </summary>
    /// <param name="source">事件源</param>
    /// <param name="e">计费指示事件参数</param>
    public delegate void UapChargeindEventHandler(object source, UapChargeindEventArgs e);

    /// <summary>
    /// 计费指示事件参数
    /// </summary>
    public class UapChargeindEventArgs : UapEventArgs
    {
        private UapChargeind _response;

        /// <summary>
        /// 访问计费指示事件源的数据
        /// </summary>
        public UapChargeind ChargeindUap
        {
            get
            {
                return _response;
            }
        }

        /// <summary>
        /// 创建计费指示事件参数
        /// </summary>
        /// <param name="response">UapChargeind包</param>
        public UapChargeindEventArgs(UapChargeind response)
            : base(response)
        {
            _response = response;
        }
    }

    #endregion UapChargeindEvent:计费指示

    #region UapChargeindRespEvent:计费指示应答
    /// <summary>
    /// 计费指示应答事件的委托
    /// </summary>
    /// <param name="source">事件源</param>
    /// <param name="e">计费指示应答事件参数</param>
    public delegate void UapChargeindRespEventHandler(object source, UapChargeindRespEventArgs e);

    /// <summary>
    /// 计费指示应答事件参数
    /// </summary>
    public class UapChargeindRespEventArgs : UapEventArgs
    {
        private UapChargeindResp _response;

        /// <summary>
        /// 访问计费指示应答事件源的数据
        /// </summary>
        public UapChargeindResp ChargeindRespUap
        {
            get
            {
                return _response;
            }
        }

        /// <summary>
        /// 创建计费指示应答事件参数
        /// </summary>
        /// <param name="response">UapChargeindResp包</param>
        public UapChargeindRespEventArgs(UapChargeindResp response)
            : base(response)
        {
            _response = response;
        }
    }

    #endregion UapChargeindRespEvent:计费指示应答

    #region UapSwitchBeginEvent:开始转移USSD会话
    /// <summary>
    /// 开始转移USSD会话事件的委托
    /// </summary>
    /// <param name="source">事件源</param>
    /// <param name="e">开始转移USSD会话事件参数</param>
    public delegate void UapSwitchBeginEventHandler(object source, UapSwitchBeginEventArgs e);

    /// <summary>
    /// 开始转移USSD会话事件参数
    /// </summary>
    public class UapSwitchBeginEventArgs : UapEventArgs
    {
        private UapSwitchBegin _response;

        /// <summary>
        /// 访问开始转移USSD会话事件源的数据
        /// </summary>
        public UapSwitchBegin SwitchBeginUap
        {
            get
            {
                return _response;
            }
        }

        /// <summary>
        /// 创建开始转移USSD会话事件参数
        /// </summary>
        /// <param name="response">UapSwitchBegin包</param>
        public UapSwitchBeginEventArgs(UapSwitchBegin response)
            : base(response)
        {
            _response = response;
        }
    }

    #endregion UapSwitchBeginEvent:开始转移USSD会话

}