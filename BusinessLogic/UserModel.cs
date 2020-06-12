using System.Data;
namespace BusinessLogic
{
	public class UserModel
    {
		private int _accountLevel;

		public int accountLevel
		{
			get { return _accountLevel; }
			set { _accountLevel = value; }
		}

		private string _email;

		public string email
		{
			get { return _email; }
			set { _email = value; }
		}
		private string _password;

		public string password
		{
			get { return _password; }
			set { _password = value; }
		}

		private int _userId;

		public int userID
		{
			get { return _userId; }
			set { _userId = value; }
		}

		private string _userName;

		public string userName
		{
			get { return _userName; }
			set { _userName = value; }
		}

		private int _userLevel;

		public int userLevel
		{
			get { return _userLevel; }
			set { _userLevel = value; }
		}

		private int myVar;

		public int MyProperty
		{
			get { return myVar; }
			set { myVar = value; }
		}

		public static UserModel Parse(DataRow row)
		{
			UserModel user = new UserModel();
			user.userID = (int)row.ItemArray[0];
			user.userName = (string)row.ItemArray[1];
			user.userLevel = (int)row.ItemArray[3];
			return user;
		}
	}
}
