using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomaszGrochowskiZadanieDomowe8
{
    /// <summary>
    /// Observer class
    /// </summary>
    public class Observer
    {
        /// <summary>
        /// Dictionary in which subscriptions are stored
        /// </summary>
        private Dictionary<int, Action<Notification>> subscriptions = new Dictionary<int, Action<Notification>>();

        /// <summary>
        /// Next subscription's id
        /// </summary>
        private int id = 0;

        /// <summary>
        /// Method registering for subscription
        /// </summary>
        /// <param name="callback"></param>
        /// <returns></returns>
        internal int Register(Action<Notification> callback)
        {
            subscriptions.Add(id, callback);
            return id++;
        }

        /// <summary>
        /// Method for unsubscribing
        /// </summary>
        /// <param name="token"></param>
        internal void UnRegister(int token)
        {
            subscriptions.Remove(token);
        }

        /// <summary>
        /// Method for notifying listeners about events
        /// </summary>
        /// <param name="notification"></param>
        internal void Notify(Notification notification)
        {
            foreach (var subscription in subscriptions)
            {
                subscription.Value(notification);
            }
        }
    }
}
