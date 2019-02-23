using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimulationBateriaTorres
{
	public partial class MainForm : Form
	{
		//Eventhandler	
		EventHandler MyEventHandler;
		
		//This bool Control the Charge/uncharge of the Battery
		bool Plugged = false;
		
		
		//ControlVars
		bool BatteryWarining = false;
		bool BatteryFull = false;
		bool BatteryEmpty = false;
		
		//ContainerClass
		EventData Data = new EventData();
	

		
		public MainForm()
		{
			InitializeComponent();
		}
		
		
		
#region MyMethods
		
		
		//Main event Method
		void MessageEvent(object Sender, EventArgs e)
		{
			MessageBox.Show(((EventData)Sender).Mensaje);
			
			if(((EventData)Sender).Apagar)
				Shutdown();
		}
		
		
		//DischargueBatteryMethod
		void Discharge(int i)
		{
			PbBateria.Increment(-(TbVolumen.Value + TbBrillo.Value + i));
		}
				

		//Shutdown the PC	
		void Shutdown()
		{
			Close();
		}
		
#endregion
		
#region DefaultMethods


		//MainFormLoad - Init Eventhandler
		void MainFormLoad(object sender, EventArgs e)
		{
			MyEventHandler += MessageEvent;
		}
		
		
		//Timer - "MainMethod"
		void TimerTick(object sender, EventArgs e)
		{
			//displays time
			LabelHora.Text = DateTime.Now.ToString("T");
			
			
			//Charge/Uncharge CodeBlock
			if(Plugged)
			{
				BatteryWarining = false;
				BatteryEmpty = false;
				
				PbBateria.Increment(50);
			}
			else
			{
				Discharge(1);
				BatteryFull = false;
			}
			
			
			
			//Full-Battery Conditions
			if(PbBateria.Value >= 1000 && !BatteryFull)
			{
				BatteryFull = true;
				Data.Mensaje = "The battery is full.";
				
				MyEventHandler(Data, null);
			}			
			//Warning-Battery Conditions
			else if(PbBateria.Value <= 150 && PbBateria.Value > 0 && !BatteryWarining && !Plugged)
			{
				Data.Mensaje = "Connect the charger";
				BatteryWarining = true;
				
				MyEventHandler(Data, null);
			}	
			//Empty-Battery Conditions		
			else if(PbBateria.Value == 0 && !BatteryEmpty)
			{
				Data.Mensaje = "The PC will shut down.";
				Data.Apagar = true;
				BatteryEmpty = true;
				
				MyEventHandler(Data, null);
			}
		 }		

		
		
		//Plug/unplug Checkbox
		void CbCargadorCheckedChanged(object sender, EventArgs e)
		{
			Plugged = CbCargador.Checked;			
			CbCargador.Text = (Plugged) ? "unplug the charger" : "plug the chargerr";
		}
			
		
		//Shutdown Button
		void BtnApagarClick(object sender, EventArgs e)
		{
			Shutdown();
		}
			

		//DebugButton - FastDischarge	
		void BtnDescargaClick(object sender, EventArgs e)
		{
			if(!Plugged)
				Discharge(50);
		}
		
		
		//ScrollVolumen - Change Volumen Text Label
		void TbVolumenScroll(object sender, EventArgs e)
		{
			LabelVolumen.Text = TbVolumen.Value.ToString();
		}
		
		//ScrollBrillo - Change Brightness Text Label
		void TbBrilloScroll(object sender, EventArgs e)
		{
			LabelBrillo.Text = TbBrillo.Value.ToString();
		}	

#endregion
	}
}
