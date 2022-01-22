using System;
namespace AuthServer.Core.UnitOfWork
{
	public interface IUnitOfWork
	{
		// Task -> void
		Task CommitAsync();
		void Commit();
	}
}

