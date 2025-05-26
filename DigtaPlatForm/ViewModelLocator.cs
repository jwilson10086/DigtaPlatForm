using CommonServiceLocator;
using DigtaPlatForm.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigtaPlatForm
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            // 设置服务定位器提供程序
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            // 注册 LoginViewModels 类型
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<MainViewModel>();
        }

        // 获取 LoginViewModels 实例
        public LoginViewModel value => ServiceLocator.Current.GetInstance<LoginViewModel>();
        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
       
    }

}

