using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Persistent.BaseImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DXApplication1.Module.BusinessObjects
{
    //[NavigationItem("Setup")]
    [ImageName("MultipleSheet")]
    [XafDefaultProperty("AccountType")]
    [Appearance("accounttypes_1", AppearanceItemType = "Action", TargetItems = "New,Delete,Edit", Context = "Any",
        Visibility = DevExpress.ExpressApp.Editors.ViewItemVisibility.Hide)]
    public partial class AccountTypes : XPObject
    {
        private string _accountType;
        private string _masterAccountType;
        private string _test2;
        private string _test3;
        private string _test4;
        private string _test5;
        public AccountTypes(Session session) : base(session)
        {
        }
        [DevExpress.ExpressApp.Model.ModelDefault("AllowEdit", "False")]
        public string AccountType
        {
            get
            {
                return _accountType;
            }
            set
            {
                SetPropertyValue("AccountType", ref _accountType, value);
            }
        }
        public string MasterAccountType
        {
            get
            {
                return _masterAccountType;
            }
            set
            {
                SetPropertyValue("MasterAccountType", ref _masterAccountType, value);
            }
        }
        public string Test2
        {
            get
            {
                return _test2;
            }
            set
            {
                SetPropertyValue("Test2", ref _test2, value);
            }
        }
        public string Test3
        {
            get
            {
                return _test3;
            }
            set
            {
                SetPropertyValue("Test3", ref _test3, value);
            }
        }
        public string Test4
        {
            get
            {
                return _test4;
            }
            set
            {
                SetPropertyValue("Test4", ref _test4, value);
            }
        }
        public string Test5
        {
            get
            {
                return _test5;
            }
            set
            {
                SetPropertyValue("Test5", ref _test5, value);
            }
        }
    }
}
