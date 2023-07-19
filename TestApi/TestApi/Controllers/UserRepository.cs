using TestApi.Models;
using System;
using Microsoft.EntityFrameworkCore;

namespace TestApi.Controllers
{
	public class UserRepository
	{
		private readonly UserContext _context;
		public int UserCount => _context.Users.Count();
		public UserRepository(UserContext context)
		{
			_context = context;
		}
		public List<User>? GetUsersAll() {
			return  _context.Users.ToList();
		}
		public User? getByName(string name) {
			return _context.Users.Where((i => i.Name == name)).FirstOrDefault();
		}
		public void Add(User user) {
			_context.Add(user);
			_context.SaveChanges();
		}
		public void Update(User user) {
			var obj = _context.Users.Where(i => i.Id == user.Id);
			if (obj != null)
			{
				_context.Update(obj);
			}
		}
		public void Delete(User user) {
            var obj = _context.Users.Where(i => i.Id == user.Id);
			if (obj != null)
			{
				_context.Remove(obj);
			}
        } 
	}
}

