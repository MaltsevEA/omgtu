﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34014
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace maltsev_tasks_2s_zas123.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Мальцев Е.А. (гр. ЗАС-123) - Задачи 2го семестра")]
        public string ApplicationTitle {
            get {
                return ((string)(this["ApplicationTitle"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Дана последовательность слов, разделённых пробелами. Вывести эту же последователь" +
            "ность, удалив из нее повторные вхождения слов.")]
        public string Task1Description {
            get {
                return ((string)(this["Task1Description"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("У попа была собака Он ее любил Она съела кусок мяса Он ее убил И в землю закопал " +
            "И надпись написал")]
        public string Task1Text {
            get {
                return ((string)(this["Task1Text"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Дана строка, состоящая из слов, разделенных пробелами. Определить, сколько в стро" +
            "ке слов, содержащих четное число символов.")]
        public string Task2Description {
            get {
                return ((string)(this["Task2Description"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"Строки в C# это не простые переменные типа int или bool. Когда мы объявляем какую-либо переменную, то система сразу знает сколько памяти необходимо выделить для хранения значения. Как в этом случае системе быть со строками? Каждый символ в строке занимает 2 байта, но количество символов может быть разным.")]
        public string Task2Text {
            get {
                return ((string)(this["Task2Text"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Дан текстовый файл F. Найти предложение с максимальным количеством слов, состоящи" +
            "х из N символов. Если таких предложений с максимальным количеством слов нескольк" +
            "о, найти их все. Переписать эти предложения в другой файл G.")]
        public string Task3Description {
            get {
                return ((string)(this["Task3Description"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"Вскоре после маленькой княгини вошел массивный, толстый молодой человек с стриженою головой, в очках, светлых панталонах по тогдашней моде, с высоким жабо и в коричневом фраке. Этот толстый молодой человек был незаконный сын знаменитого Екатерининского вельможи, графа Безухого, умиравшего теперь в Москве. Он нигде не служил еще, только что приехал из-за границы, где он воспитывался, и был в первый раз в обществе. Анна Павловна приветствовала его поклоном, относящимся к людям самой низшей иерархии в ее салоне. Но, несмотря на это низшее по своему сорту приветствие, при виде вошедшего Пьера в лице Анны Павловны изобразилось беспокойство и страх, подобный тому, который выражается при виде чего-нибудь слишком огромного и несвойственного месту. Хотя, действительно, Пьер был несколько больше других мужчин в комнате, но этот страх мог относиться только к тому умному и вместе робкому, наблюдательному и естественному взгляду, отличавшему его от всех в этой гостиной.")]
        public string Task3Text {
            get {
                return ((string)(this["Task3Text"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Реализовать проверку данного натурального числа на простоту с помощью решета Эрат" +
            "осфена и сравнить его со скоростью работы метода прямой проверки, перебирающей в" +
            "озможные дели-тели.")]
        public string Task4Description {
            get {
                return ((string)(this["Task4Description"]));
            }
            set {
                this["Task4Description"] = value;
            }
        }
    }
}
