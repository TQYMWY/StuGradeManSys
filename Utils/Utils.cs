namespace StuGradeManSys.Utils
{
    public static class Utils
    {
        public static Dictionary<string, object> getProperties(this object obj)
        {
            Type type = obj.GetType();
            var properties = type.GetProperties();
            Dictionary<string, object> map = new Dictionary<string, object>();
            foreach (var property in properties)
            {
                var value = property.GetValue(obj);
                if (value != null)
                    map.Add(property.Name, value);
            }
            return map;
        }
        public static T Copy<T>(this object obj) where T : new()
        {
            Type type = obj.GetType();
            var properties = type.GetProperties();
            T res = new T();
            foreach (var property in properties)
            {
                property.SetValue(res, property.GetValue(obj));
            }
            return res;
        }
        public static string UtilToString(this object? obj)
        {
            string res = "";
            if (obj == null) return res;
            var map = obj.getProperties();
            foreach (var kv in map)
            {
                res += kv.Key + "=" + kv.Value + "\n";
            }
            return res;
        }
        public static void CloseForm(this Panel panel)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
        }
        public static void OpenForm(this Panel panel, Form subForm)
        {
            panel.CloseForm();
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Parent = panel;
            subForm.Dock = DockStyle.Fill;
            subForm.Show();
        }

    }
}
