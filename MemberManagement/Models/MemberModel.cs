using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MemberManagement.Models
{
    public class MemberModel
    {
		/// <summary>
		/// 註冊參數
		/// </summary>
		public class DoRegisterIn
		{
			public string UserID { get; set; }
			public string UserPwd { get; set; }
			public string UserName { get; set; }		
			public string UserEmail { get; set; }
			public DateTime BirthDay { get; set; }
		}

		/// <summary>
		/// 註冊回傳
		/// </summary>
		public class DoRegisterOut
		{
			public string ErrMsg { get; set; }
			public string ResultMsg { get; set; }
		}

		/// <summary>
		/// 登入參數
		/// </summary>
		public class DoLoginIn
		{
			public string UserID { get; set; }
			public string UserPwd { get; set; }
		}

		/// <summary>
		/// 登入回傳
		/// </summary>
		public class DoLoginOut
		{
			public string ErrMsg { get; set; }
			public string ResultMsg { get; set; }
		}

		/// <summary>
		/// 取得個人資料回傳
		/// </summary>
		public class GetUserProfileOut
		{
			public string ErrMsg { get; set; }
			public string UserID { get; set; }
			public string UserName { get; set; }
			public string UserEmail { get; set; }
		}

		/// <summary>
		/// 修改個人資料參數
		/// </summary>
		public class DoEditProfileIn
		{
			public string UserName { get; set; }
			public string UserEmail { get; set; }
		}

		/// <summary>
		/// 修改個人資料回傳
		/// </summary>
		public class DoEditProfileOut
		{
			public string ErrMsg { get; set; }
			public string ResultMsg { get; set; }
		}

		/// <summary>
		/// 修改密碼參數
		/// </summary>
		public class DoEditPwdIn
		{
			public string NewUserPwd { get; set; }
			public string CheckUserPwd { get; set; }
		}

		/// <summary>
		/// 修改密碼回傳
		/// </summary>
		public class DoEditPwdOut
		{
			public string ErrMsg { get; set; }
			public string ResultMsg { get; set; }
		}
	}

	
}