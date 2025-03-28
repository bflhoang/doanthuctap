using Newtonsoft.Json;

namespace BeeComputer.Repository
{
    public static class SessionExtensions
    {
        //luu du lieu vao session
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        //Lay du lieu tu session
        public static T GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);
            return sessionData == null ? default(T) : JsonConvert.DeserializeObject<T>(sessionData);
        }
    }
}
