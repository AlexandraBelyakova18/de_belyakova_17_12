using System;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace RepairRequestApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Включаем визуальные стили для приложения
            Application.EnableVisualStyles();
            // Устанавливаем совместимый режим рендеринга текста
            Application.SetCompatibleTextRenderingDefault(false);
            // Запускаем основную форму приложения
            Application.Run(new FormMain());
        }
    }
}
