namespace CurrencyConvServiceHost
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MySPInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstallerHost = new System.ServiceProcess.ServiceInstaller();
            // 
            // MySPInstaller
            // 
            this.MySPInstaller.Account = System.ServiceProcess.ServiceAccount.NetworkService;
            this.MySPInstaller.Password = null;
            this.MySPInstaller.Username = null;
            // 
            // serviceInstallerHost
            // 
            this.serviceInstallerHost.Description = "This is the host for WCF service (CurrencyConvService)";
            this.serviceInstallerHost.ServiceName = "CurrencyConverter Service";
            this.serviceInstallerHost.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.MySPInstaller,
            this.serviceInstallerHost});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller MySPInstaller;
        private System.ServiceProcess.ServiceInstaller serviceInstallerHost;
    }
}