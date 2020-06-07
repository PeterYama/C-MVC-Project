using System.Data;

namespace BusinessLogic
{
	public class UserModel
    {
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
