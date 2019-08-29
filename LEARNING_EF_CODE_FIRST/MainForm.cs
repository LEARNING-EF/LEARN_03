namespace LEARNING_EF_CODE_FIRST
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			// *************************************
			// *** How to use disposable classes ***
			// *************************************

			// Solution (1)
			//DisposableClass obj = null;

			//try
			//{
			//	obj = new DisposableClass();

			//	// با شیء مربوطه کار می کنيم
			//}
			//catch (System.Exception ex)
			//{
			//	// خطای مناسب را لاگ کرده و پيغام مناسب را به کاربر نمايش می دهيم
			//}
			//finally
			//{
			//	if(obj != null)
			//	{
			//		obj.Dispose();
			//		obj = null;
			//	}
			//}
			// /Solution (1)

			// Solution (2)
			//using (DisposableClass obj =  new DisposableClass())
			//{
			//}
			// /Solution (2)

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				//Models.Person person = new Models.Person();

				//person.Id = 1;
				//person.Age = 47;
				//person.IsSupervisor = true;
				//person.FullName = "Mr. Dariush Tasdighi";

				Models.Person person =
					new Models.Person
					{
						Id = 1,
						Age = 47,
						IsSupervisor = true,
						FullName = "Mr. Dariush Tasdighi",
					};

				// بعد از دستور ذيل، در صورتی که بانک اطلاعاتی
				// وجود نداشته باشد، بانک اطلاعاتی ايجاد می گردد
				databaseContext.People.Add(person);

				databaseContext.SaveChanges();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					//databaseContext = null;
				}
			}
		}
	}
}
