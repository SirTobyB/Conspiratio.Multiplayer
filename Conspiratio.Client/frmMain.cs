using Conspiration.NetzwerkLib;
using Network;
using Network.Enums;
using System;
using System.Text;
using System.Windows.Forms;

namespace Conspiratio.Client
{
    public partial class frmMain : Form
    {
        #region Variablen

        private ClientConnectionContainer oClientConnectionContainer = null;
        private Netzwerk oNetzwerk = new Netzwerk();
        private StringBuilder oStringBuilderLog = new StringBuilder("");

        private delegate void LogSetzenCallback(string sText);

        #endregion

        #region frmMain
        public frmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region frmMain_Load
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                // Werte für den Server auslesen und setzen
                txtUsername.Text = Environment.UserName;
                txtServer.Text = oNetzwerk.LokaleIPAdresseErmitteln();
                txtPort.Text = oNetzwerk.StandardPort.ToString();
            }
            catch (Exception ex)
            {
                oStringBuilderLog.Append("Fehler bei der Initialisierung: " + ex.Message + Environment.NewLine);
                LogSetzen(oStringBuilderLog.ToString());
            }
        }
        #endregion

        #region btnVerbinden_Click
        private void btnVerbinden_Click(object sender, EventArgs e)
        {
            if (oClientConnectionContainer == null)
            {
                // Client Connection erstellen, wenn noch nicht vorhanden
                oClientConnectionContainer = ConnectionFactory.CreateClientConnectionContainer(txtServer.Text, Convert.ToInt32(txtPort.Text));
                oClientConnectionContainer.AutoReconnect = true;

                oClientConnectionContainer.ConnectionEstablished += ClientConnectionContainer_ConnectionEstablished;
                oClientConnectionContainer.ConnectionLost += oClientConnectionContainer_ConnectionLost;

                txtPort.Enabled = false;   // Eine Änderung des Ports ist während der Runtime nicht möglich
            }

            oClientConnectionContainer.Reconnect();
            btnVerbinden.Enabled = false;
            btnTrennen.Enabled = true;
        }
        #endregion

        #region oClientConnectionContainer_ConnectionLost
        private void oClientConnectionContainer_ConnectionLost(Connection arg1, ConnectionType arg2, Network.Enums.CloseReason arg3)
        {
            oStringBuilderLog.Append(string.Format("Verbindung mit Server getrennt ({0}): {1}{2}", arg2.ToString(), arg3.ToString(), Environment.NewLine));
            LogSetzen(oStringBuilderLog.ToString());
        }
        #endregion

        #region ClientConnectionContainer_ConnectionEstablished
        private void ClientConnectionContainer_ConnectionEstablished(Connection connection, ConnectionType type)
        {
            oStringBuilderLog.Append(string.Format("Verbindung mit Server erfolgreich hergestellt ({0}).{1}", type.ToString(), Environment.NewLine));
            LogSetzen(oStringBuilderLog.ToString());

            //Console.WriteLine($"{type.ToString()} Connection established");
            //3. Register what happens if we receive a packet of type "CalculationResponse"
            //container.RegisterPacketHandler<CalculationResponse>(calculationResponseReceived, this);
            //4. Send a calculation request.
            //connection.Send(new CalculationRequest(10, 10), this);
        }
        #endregion

        #region btnTrennen_Click
        private void btnTrennen_Click(object sender, EventArgs e)
        {
            oClientConnectionContainer.Shutdown(Network.Enums.CloseReason.ClientClosed, true);
            btnVerbinden.Enabled = true;
            btnTrennen.Enabled = false;
        }
        #endregion


        #region LogSetzen
        private void LogSetzen(string sText)
        {
            if (this.txtServerlog.InvokeRequired)
            {
                LogSetzenCallback d = new LogSetzenCallback(LogSetzen);
                this.Invoke(d, new object[] { sText });
            }
            else
            {
                this.txtServerlog.Text = sText;
            }
        }
        #endregion
    }
}
