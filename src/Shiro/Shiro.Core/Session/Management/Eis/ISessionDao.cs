using System.Collections.Generic;

namespace Apache.Shiro.Session.Management.Eis
{
    public interface ISessionDao
    {
        object Create(ISession session);

        void Delete(ISession session);

        ICollection<ISession> GetActiveSessions();

        ISession Read(object sessionId);

        void Update(ISession session);
    }
}
