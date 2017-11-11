using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Conspiration.NetzwerkLib
{
    #region Enumerator NetzwerkAktion
    public enum NetzwerkAktion
    {
        Login,
        Logout,
        Chat
    }
    #endregion

    #region NetzwerkNachricht
    public struct NetzwerkNachricht
    {
        #region Variablen

        private string fsUsername;
        private NetzwerkAktion feAktion;
        private string fsNachricht;

        #endregion

        #region Properties

        public string Username
        {
            get { return fsUsername; }
            set { fsUsername = value; }
        }

        public NetzwerkAktion Aktion
        {
            get { return feAktion; }
            set { feAktion = value; }
        }

        public string Nachricht
        {
            get { return fsNachricht; }
            set { fsNachricht = value; }
        }
        #endregion
    }
    #endregion

    public class Netzwerk
    {
        #region Variablen

        private const int fiStandardPort = 60000;

        #endregion

        #region Funktionen

        #region LokaleIPAdresseErmitteln
        /// <summary>
        /// LokaleIPAdresseErmitteln: Dient zur Ermittlung der lokalen IP-Adresse einer physikalischen Netzwerkkarte.
        /// </summary>
        /// <returns>IP-Adresse, wenn gefunden. Ansonsten ein leerer String.</returns>
        public string LokaleIPAdresseErmitteln()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface network in networkInterfaces)
            {
                IPInterfaceProperties properties = network.GetIPProperties();

                foreach (IPAddressInformation address in properties.UnicastAddresses)
                {
                    if ((address.Address.AddressFamily == AddressFamily.InterNetwork) &
                        !(IPAddress.IsLoopback(address.Address)) &
                        (network.OperationalStatus == OperationalStatus.Up) &
                        !(network.Description.Contains("virtual")) &
                        !(network.Description.Contains("Virtual")))
                    {
                        return address.Address.ToString();
                    }
                }
            }

            return "";
        }
        #endregion

        #endregion

        #region Properties
        /// <summary>
        /// Gibt den Standardport zur Verbindung mit einem Server an
        /// </summary>
        public int StandardPort
        {
            get { return fiStandardPort; }
        }
        #endregion
    }
}