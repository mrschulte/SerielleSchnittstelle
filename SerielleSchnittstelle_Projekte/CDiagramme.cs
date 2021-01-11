/*
 * Created by SharpDevelop.
 * Autor: Josef Pedevilla
 * Date: 06.09.2011
 * Letzte Änderung: 18.03.2020
 * 
 * Bei der Deklaration einer Instanz der Klasse CDiagramme eine PictureBox übergeben und den Diagrammtyp (als String) angeben.
 * z.B. 	CDiagramme Amplitudengang;  // Deklaration
 *  		Amplitudengang = new CDiagramme(pictureBox1,"Amplitudengang"); // Instanziierung
 * 
 * Diagrammtypen:
 * - Zeitdiagramm
 * - xy-Diagramm
 * - Amplitudengang
 * - Phasengang
 * 
 * Zeitdiagramm: - der Ursprung des Koordinatensystems liegt horizontal links und vertikal in der Mitte der PictureBox
 * 				 - die Einteilung der x-Achse wird durch die Eigenschaften XAnfangswert, XEndwert
 * 				   und Anzahl_Teilungen_X bestimmt.
 * 				 - die Einteilung der y-Achse  wird durch die Eigenschaften Anzahl_Teilungen_Y und Teilung_Y bestimmt.
 * 				  
 * xy-Diagramm: - der Ursprung des Koordinatensystems liegt horizontal und vertikal in der Mitte der PictureBox
 *              - die Einteilung der x-Achse  wird durch die Eigenschaften Anzahl_Teilungen_X und Teilung_X bestimmt.
 * 				- die Einteilung der y-Achse  wird durch die Eigenschaften Anzahl_Teilungen_Y und Teilung_Y bestimmt.
 * 
 * Amplitudengang: - die Anzahl der dargestellten Dekaden ist 5 (nicht einstellbar),
 *                 - die Startfrequenz darf gewählt werden,
 * 	               - die Y-Achse (Einheit Dezibel) kann über die Eigenschaften Einteilung_Y und Anzahl_Teilungen_Y skaliert werden
 * 				             
 * Phasengang:     - die Anzahl der dargestellten Dekaden ist 5 (nicht einstellbar),
 *                 - die Startfrequenz darf gewählt werden,
 * 	               - die Y-Achse (Einheit Grad) kann über die Eigenschaften Einteilung_Y und Anzahl_Teilungen_Y skaliert werden
 * 
 * Alle Zeichenfunktionen der Klasse erhalten als Parameter ein PointF-Array, in welchem die darzustellenden xy-Werte enthalten sind.
 * Der X-Wert des ersten Elements des Arrays muss die Anzahl der xy-Werte enthalten. ACHTUNG: um eine Kurve zeichnen zu können muss
 * die Anzahl größer als 1 sein.
 * 
 * Änderung 18.03.2020: Für den Diagrammtyp xy-Diagramm wurde die Methode xyGaussKomplexeZahlenDarstellen(int n, PointF [] zArr)
 * hinzugefügt
 * 
 */
 
using System;
using System.Drawing;


namespace Diagramme
{
	/// <summary>
	/// Description of CxyDiagramm.
	/// </summary>
	public class CDiagramme
	{
		public bool koordinaten_OK;
		
		private string diagrammtyp;
		private float pictureHöhe;
		private float pictureBreite;
		
		private PointF Ursprung;
		private string positionUrsprung;
		
		private float xAnfangswert;
		private float xEndwert;
		private float xTeilungPixel;
		private float yTeilungPixel;
		private float xTeilungWert;
		private float yTeilungWert;
		private int x_N_Teilungen;
		private int y_N_Teilungen;
		
		private float rand_L;
		private float rand_R;
		private float rand_Unten;
		private float rand_Oben;
		private float offsetL;	
		private float abstandBeschry;
		private float abstandBeschrx;
		private float abst_schrift_cursor;
				
		private Color farbe_Koordinatensystem;
		private Color farbe_Raster;
		private Pen stiftKoordinatensystem; 
		private Pen stiftRaster; 
		private Pen stiftFunk1;
		private Color farbeFunktion1;
		private int textGroesse;
		
		private float startfrequenz;
		private string einheit_y;
		
		private System.Windows.Forms.PictureBox picB;
		
		bool first = true;
		
		
		
		
		public CDiagramme(System.Windows.Forms.PictureBox picBox,string Typ)
		{
			picB = picBox;
			if (picB == null) 
			{
				System.Windows.Forms.MessageBox.Show("Keine Picturebox gefunden");
			}
			
			else
			{
			    koordinaten_OK = false;
			    pictureHöhe= picB.Height;
			    pictureBreite = picB.Width;
			    
			   	
			   	rand_L=35F;
			   	rand_Oben=0F;
			   	rand_R=0F;
			   	rand_Unten=25F;
			   	offsetL=+2;
			   	abstandBeschry = 3;
			   	abstandBeschrx = 5;
			   	abst_schrift_cursor = 8;
			   
			   	xTeilungWert=90f;
		   
			    farbeFunktion1 = Color.Tomato;
			    stiftKoordinatensystem = new Pen(farbe_Koordinatensystem);
			   
			    stiftRaster = new Pen(farbe_Raster,1);
			    
			    diagrammtyp = Typ;
			    
			    //koordimage = new Bitmap(picB.Image);
			    
			    if(Typ=="Amplitudengang")
			    {	
			    	positionUrsprung = "mitte-links";
			    	x_N_Teilungen=5;
			    	startfrequenz =1f;
			    	y_N_Teilungen=6;
			   		yTeilungWert=20F;
			   		einheit_y="";
			    }
			    else if(Typ =="Phasengang")
			   	{
			    	positionUrsprung = "mitte-links";
			    	x_N_Teilungen=5;
			    	startfrequenz =1f;
			    	y_N_Teilungen=10;
			   		yTeilungWert=45F;
			   		einheit_y="°";
			   	}
			    else if(Typ =="Zeitdiagramm")
			    {
			    	positionUrsprung = "mitte-links";/*"unten-links";*/
			    	x_N_Teilungen=10;
			   		xAnfangswert = 0F;
			   		xEndwert = 100F;
			        y_N_Teilungen=10;
			   		yTeilungWert=10F;
			   		einheit_y="";
			    }
			    else if(Typ =="xy-Diagramm")
			    {
			    	positionUrsprung = "mitte-mitte";
			    	xAnfangswert =0f;
			    	x_N_Teilungen=10;
			   		xTeilungWert=10f;
			        y_N_Teilungen=10;
			   		yTeilungWert=10f;
			   		
			    }
			    
			   
			    farbe_Koordinatensystem=Color.Black;
			    farbe_Raster=Color.White;
			   	textGroesse = 8;
			}
		}
		
		
		
		public Color Farbe_Koordinatensystem
		{
			get{ return farbe_Koordinatensystem; }
			set{ farbe_Koordinatensystem = value; }
		}
		
		public Color Farbe_Raster
		{
			get{ return farbe_Raster; }
			set{ farbe_Raster = value; }
		}
		
		public Color Farbe_Kennlinie
		{
			get{ return farbeFunktion1; }
			set{ farbeFunktion1 = value; }
		}
		
		public string PositionUrsprung
		{
			get{ return positionUrsprung; }
			set{ positionUrsprung = value; }
		}
		
		public float XAnfangswert
		{
			get{ return xAnfangswert; }
			set{ xAnfangswert = value; }
		}
		
		public float XEndwert
		{
			get{ return xEndwert; }
			set{ xEndwert = value; }
		}
		
		public int Anzahl_Teilungen_X
		{
			get{ return x_N_Teilungen; }
			set{ x_N_Teilungen = value; }
		}
		
		public float Startfrequenz
		{
			get{ return startfrequenz; }
			set{ startfrequenz = value; }
		}
		
		public int Anzahl_Teilungen_Y
		{
			get{ return y_N_Teilungen; }
			set{ y_N_Teilungen = value; }
		}
		
		public float Teilung_Y
		{
			get{ return yTeilungWert; }
			set{ yTeilungWert = value; }
		}
		
		public float Teilung_X
		{
			get{ return xTeilungWert; }
			set{ xTeilungWert = value; }
		}
		
		public string Einheit_Y_Achse
		{
			get{ return einheit_y; }
			set{ einheit_y = value; }
		}
		
		
		public int Text_Größe
		{
			get{ return textGroesse; }
			set{ textGroesse = value; }
		}
//		public string Position_Ursprung //*************************
//		{
//			get{ return positionUrsprung; }
//			set{ positionUrsprung = value; }
//		}
		
		
		private void diagrammInit()
		{
			Image koordimage = new Bitmap(picB.Width,picB.Height);
			Graphics g = Graphics.FromImage(koordimage);
			
			Font myfont = new Font("Tahoma", textGroesse, FontStyle.Regular);
			SolidBrush mybrush = new SolidBrush(Color.Black);
			StringFormat strFormat = new StringFormat(); 
			
			//g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
			
			g.TextContrast = 1;
			
			stiftKoordinatensystem.Color=farbe_Koordinatensystem;
			stiftRaster.Color=farbe_Raster;
			
			string st;
			
			koordinaten_OK=true;
			
			if(diagrammtyp == "Amplitudengang" || diagrammtyp == "Phasengang")
			{
				
				positionUrsprung = "mitte-links";
	
				xTeilungWert=(float) ((xEndwert-xAnfangswert)/x_N_Teilungen);
				xTeilungPixel = (float) Math.Round((pictureBreite-rand_L-20)/x_N_Teilungen,0);
			    yTeilungPixel = (pictureHöhe-rand_Unten)/y_N_Teilungen;//change /2
			    
				Ursprung.X = rand_L;
				Ursprung.Y = (pictureHöhe-rand_Unten)/2;
				strFormat.Alignment = StringAlignment.Far; 
				
				// y-Achse beschriften
				int l=0;
				for (int i = 0; pictureHöhe-yTeilungPixel*i-rand_Unten>=0; i++) 
				{							
	  				st= String.Format("{0}",(i*yTeilungWert-yTeilungWert*y_N_Teilungen/2)+einheit_y); //change *2
	  				
  					if( pictureHöhe-yTeilungPixel*i-(rand_L+abstandBeschry)>5)
	  					g.DrawString(st,myfont,mybrush,rand_L-abstandBeschry, pictureHöhe-yTeilungPixel*i-(rand_L-offsetL), strFormat);
  					g.DrawLine(stiftRaster,rand_L,pictureHöhe-yTeilungPixel*i-rand_Unten,pictureBreite,pictureHöhe-yTeilungPixel*i-rand_Unten);
  					l=i;
	     		}
						
				st="[dB]";
				if(diagrammtyp == "Amplitudengang")
					g.DrawString(st,myfont,mybrush,rand_L-abstandBeschry, yTeilungPixel/2-10, strFormat);
							
				// x-Achse beschriften
				float posx=rand_L;
				int dekade= 1;
				int schritt;
				int strich=0;
				double omega=1;
				strFormat.Alignment = StringAlignment.Center; 
				
				st= String.Format("{0}",startfrequenz);
	  			g.DrawString(st,myfont,mybrush,posx,pictureHöhe-rand_Unten+abstandBeschrx, strFormat);
				
				float startfr = startfrequenz;
						
				for (int i = 1; posx<pictureBreite-rand_R  && i<100; i++)
				{
					posx=(float) (xTeilungPixel*Math.Log10(omega)+rand_L);
					g.DrawLine(stiftRaster,posx,rand_Oben,posx,pictureHöhe-rand_Unten);
	  				
	  				strich++;
	  				if((strich%10)==0)
	  				{
	  					strich=1;
	  					dekade++;
	  					startfr*=10;
	  					if(startfr>1000)
	  						st= String.Format("{0:0e+0}", startfr);
	  					else
	  						st= String.Format("{0}",Math.Round(startfr,3));

	  					g.DrawString(st,myfont,mybrush,posx,pictureHöhe-rand_Unten+abstandBeschrx, strFormat);
	  					
	  				}
	  				schritt=(int) Math.Pow(10,dekade-1);
	  				omega+=schritt;
				}
				
				st="[rad/s]";
				
				g.DrawString(st,myfont,mybrush,picB.Width-(xTeilungPixel+10)/2,pictureHöhe-rand_Unten+abstandBeschrx, strFormat);
				
				g.DrawLine(stiftKoordinatensystem,Ursprung.X,pictureHöhe-rand_Unten,Ursprung.X,0);
				g.DrawLine(stiftKoordinatensystem,Ursprung.X,Ursprung.Y,pictureBreite,Ursprung.Y);
			    
				picB.BackgroundImage = koordimage;
			}
				
			else if(diagrammtyp == "Zeitdiagramm" )
			{
				
				if((xEndwert-xAnfangswert)<0)
					System.Windows.Forms.MessageBox.Show("Anfangswert oder Endewert falsch eingegeben");				
				else 
				{
					xTeilungWert=(float) ((xEndwert-xAnfangswert)/x_N_Teilungen);
					xTeilungPixel = (float) Math.Round((pictureBreite-rand_L-20)/x_N_Teilungen,0);
				    yTeilungPixel = (pictureHöhe-rand_Unten)/y_N_Teilungen; 
				    
					if(positionUrsprung == "mitte-links")
					{
						Ursprung.X = rand_L;
						Ursprung.Y = (pictureHöhe-rand_Unten)/2;
						strFormat.Alignment = StringAlignment.Far; 
						
						// y-Achse beschriften
						for (int i = 0; pictureHöhe-yTeilungPixel*i-rand_Unten>=0; i++) 
						{							
			  				st= String.Format("{0}",(i*yTeilungWert-yTeilungWert*y_N_Teilungen/2));
			  				
		  					if( pictureHöhe-yTeilungPixel*i-(rand_L+abstandBeschry)>5)
			  					g.DrawString(st,myfont,mybrush,rand_L-abstandBeschry, pictureHöhe-yTeilungPixel*i-(rand_L-offsetL), strFormat);
							g.DrawLine(stiftRaster,rand_L,pictureHöhe-yTeilungPixel*i-rand_Unten,pictureBreite,pictureHöhe-yTeilungPixel*i-rand_Unten);
			     		}
						
						
						// x-Achse beschriften
						strFormat.Alignment = StringAlignment.Center; 
						for (int i = 0; xTeilungPixel*i+rand_L<pictureBreite-rand_R; i++) 
						{
							g.DrawLine(stiftRaster,xTeilungPixel*i+rand_L,rand_Oben,xTeilungPixel*i+rand_L,pictureHöhe-rand_Unten);
							
			  				st= String.Format("{0}",xAnfangswert+i*xTeilungWert);
			  				if(xTeilungPixel*i+rand_L<(pictureBreite-10))
			  					g.DrawString(st,myfont,mybrush,xTeilungPixel*i+rand_L,pictureHöhe-rand_Unten+abstandBeschrx, strFormat);
						}
						
						g.DrawLine(stiftKoordinatensystem,Ursprung.X,pictureHöhe-rand_Unten,Ursprung.X,0);
						g.DrawLine(stiftKoordinatensystem,Ursprung.X,Ursprung.Y,pictureBreite,Ursprung.Y);
						
						
						picB.BackgroundImage = koordimage;
						
					}
					else if(positionUrsprung == "unten-links")
					{
						Ursprung.X = rand_L;
						Ursprung.Y = pictureHöhe-rand_Unten;
						
						// y-Achse beschriften
						strFormat.Alignment = StringAlignment.Far; 
						for (int i = 0; pictureHöhe-yTeilungPixel*i-rand_Unten>=0; i++) 
						{	
			  				st= String.Format("{0}",i*yTeilungWert);
			  				
		  					if( pictureHöhe-yTeilungPixel*i-(rand_L+abstandBeschry)>5)
			  					g.DrawString(st,myfont,mybrush,rand_L-abstandBeschry, pictureHöhe-yTeilungPixel*i-(rand_L-offsetL), strFormat);
							g.DrawLine(stiftRaster,rand_L,pictureHöhe-yTeilungPixel*i-rand_Unten,pictureBreite,pictureHöhe-yTeilungPixel*i-rand_Unten);
						}
						
						
						// x-Achse beschriften
						strFormat.Alignment = StringAlignment.Center; 
						for (int i = 0; xTeilungPixel*i+rand_L<pictureBreite-rand_R; i++) 
						{
							g.DrawLine(stiftRaster,xTeilungPixel*i+rand_L,rand_Oben,xTeilungPixel*i+rand_L,pictureHöhe-rand_Unten);
							
			  				st= String.Format("{0}",i*xTeilungWert);
			  				if(xTeilungPixel*i+rand_L<(pictureBreite-10))
			  					g.DrawString(st,myfont,mybrush,xTeilungPixel*i+rand_L,pictureHöhe-rand_Unten+5, strFormat);
						}
						
						g.DrawLine(stiftKoordinatensystem,Ursprung.X,pictureHöhe-rand_Unten,Ursprung.X,0);
						g.DrawLine(stiftKoordinatensystem,Ursprung.X,Ursprung.Y,pictureBreite,Ursprung.Y);
						
						picB.BackgroundImage = koordimage;
					}
				}
			}			
			else if( diagrammtyp == "xy-Diagramm")
			{
				xTeilungPixel = (float) Math.Round((pictureBreite-rand_L-20)/x_N_Teilungen,0);
				yTeilungPixel = (pictureHöhe-rand_Unten)/y_N_Teilungen; 
				
				Ursprung.X = rand_L+x_N_Teilungen/2*xTeilungPixel;
				Ursprung.Y = (pictureHöhe-rand_Unten)/2;
				strFormat.Alignment = StringAlignment.Far; 
				
			
				// y-Achse beschriften
				for (int i = 0; pictureHöhe-yTeilungPixel*i-rand_Unten>=0; i++) 
				{							
	  				st= String.Format("{0}",(i*yTeilungWert-yTeilungWert*y_N_Teilungen/2));
  					if( pictureHöhe-yTeilungPixel*i-(rand_L+abstandBeschry)>5)
	  					g.DrawString(st,myfont,mybrush,rand_L-abstandBeschry, pictureHöhe-yTeilungPixel*i-(rand_L-offsetL), strFormat);
					g.DrawLine(stiftRaster,rand_L,pictureHöhe-yTeilungPixel*i-rand_Unten,pictureBreite,pictureHöhe-yTeilungPixel*i-rand_Unten);
	     		}
				
				
				// x-Achse beschriften
				strFormat.Alignment = StringAlignment.Center; 
				for (int i = 0; xTeilungPixel*i+rand_L<pictureBreite-rand_R; i++) 
				{
					g.DrawLine(stiftRaster,xTeilungPixel*i+rand_L,rand_Oben,xTeilungPixel*i+rand_L,pictureHöhe-rand_Unten);
					
	  				st= String.Format("{0}",i*xTeilungWert-x_N_Teilungen/2*xTeilungWert);
	  				if(xTeilungPixel*i+rand_L<(pictureBreite-10))
	  					g.DrawString(st,myfont,mybrush,xTeilungPixel*i+rand_L,pictureHöhe-rand_Unten+abstandBeschrx, strFormat);
				}
				
				g.DrawLine(stiftKoordinatensystem,Ursprung.X,pictureHöhe-rand_Unten,Ursprung.X,0);
				g.DrawLine(stiftKoordinatensystem,rand_L,Ursprung.Y,pictureBreite,Ursprung.Y);
				
				
				picB.BackgroundImage = koordimage;	
			}
					
			else
				System.Windows.Forms.MessageBox.Show("Diagrammtyp falsch eingegeben");
			
			
			
		}
		
		public void xyDiagrammzeichnen( PointF [] Array)
		{
			 if(!koordinaten_OK)
			 	diagrammInit();
			 if(diagrammtyp=="xy-Diagramm")
			 {
			 	 Image kennlimage = new Bitmap(picB.Width,picB.Height);
				 Graphics g = Graphics.FromImage(kennlimage);
				// Graphics g = picB.CreateGraphics();
				 stiftFunk1 = new Pen(farbeFunktion1,2);
				 
				 int arrayGr = (int) Array[0].X;
				
				 PointF [] graphArray = new PointF[arrayGr];
				 
				 for (int i = 0; i < arrayGr; i++) 
				 {			 			 
				 	graphArray[i].X = ((Array[i+1].X-xAnfangswert)*xTeilungPixel/xTeilungWert+Ursprung.X);
					graphArray[i].Y = Ursprung.Y-(float) (Array[i+1].Y*yTeilungPixel/yTeilungWert);
				 }
				 
				 try
				 {
				 	g.DrawCurve(stiftFunk1,graphArray,0); // Tension auf null setzen g.DrawCurve(stiftFunk1,graphArray,0);
	   			 	picB.Image=kennlimage;	
				 }
				 catch
				 {
				 	System.Windows.Forms.MessageBox.Show("Das Array muss mindestens 2 Punkte enthalten");
				 }
			 }
			 else
			 	System.Windows.Forms.MessageBox.Show("Der gewählte Diagrammtyp ist kein xy-Diagramm");
			    
		}
		
		public void xyGaussKomplexeZahl( int n, PointF [] zArr)
		{
			 if(!koordinaten_OK)
			 	diagrammInit();
			 if(diagrammtyp=="xy-Diagramm")
			 {
			 	 Image kennlimage = new Bitmap(picB.Width,picB.Height);
				 Graphics g = Graphics.FromImage(kennlimage);
				
				 Pen stift1 = new Pen(Color.Red,2);
				 Pen stift2 = new Pen(Color.BlueViolet,2);
				 Pen stift3 = new Pen(Color.Green,2);
				 
				 PointF p1 = new PointF();
				 
				 switch(n)
				 {
				 	case 1:
					 	p1.X=zArr[0].X*xTeilungPixel/xTeilungWert+Ursprung.X;
					 	p1.Y=Ursprung.Y-(float) (zArr[0].Y*yTeilungPixel/yTeilungWert);
					 	g.DrawLine(stift1,Ursprung,p1);			
					 	break;
					 	
					case 2:
					 	p1.X=zArr[0].X*xTeilungPixel/xTeilungWert+Ursprung.X;
					 	p1.Y=Ursprung.Y-(float) (zArr[0].Y*yTeilungPixel/yTeilungWert);
					 	g.DrawLine(stift1,Ursprung,p1);
					 						 	
					 	p1.X=zArr[1].X*xTeilungPixel/xTeilungWert+Ursprung.X;
					 	p1.Y=Ursprung.Y-(float) (zArr[1].Y*yTeilungPixel/yTeilungWert);
					 	g.DrawLine(stift2,Ursprung,p1);
					 	break;
				 					 				 
					case 3:
					 	p1.X=zArr[0].X*xTeilungPixel/xTeilungWert+Ursprung.X;
					 	p1.Y=Ursprung.Y-(float) (zArr[0].Y*yTeilungPixel/yTeilungWert);
					 	g.DrawLine(stift1,Ursprung,p1);
					 						 	
					 	p1.X=zArr[1].X*xTeilungPixel/xTeilungWert+Ursprung.X;
					 	p1.Y=Ursprung.Y-(float) (zArr[1].Y*yTeilungPixel/yTeilungWert);
					 	g.DrawLine(stift2,Ursprung,p1);
					 	
					 	p1.X=zArr[2].X*xTeilungPixel/xTeilungWert+Ursprung.X;
					 	p1.Y=Ursprung.Y-(float) (zArr[2].Y*yTeilungPixel/yTeilungWert);
					 	g.DrawLine(stift3,Ursprung,p1);
					 	break;
				 }
				 picB.Image=kennlimage;		
			 }
			 else
			 	System.Windows.Forms.MessageBox.Show("Der gewählte Diagrammtyp ist kein xy-Diagramm");
		}
		
		
		public void Zeitdiagrammzeichnen( PointF [] Array)
		{
			 if(!koordinaten_OK)
			 	diagrammInit();
			 if(diagrammtyp=="Zeitdiagramm")
			 {
			 	 Image kennlimage = new Bitmap(picB.Width,picB.Height);
				 Graphics g = Graphics.FromImage(kennlimage);
				 //Graphics g = picB.CreateGraphics();
				 stiftFunk1 = new Pen(farbeFunktion1,2);
				 
				 int arrayGr = (int) Array[0].X;
				
				 PointF [] graphArray = new PointF[arrayGr];
				 
				  int t=0;
				 for (int i = 0; i < arrayGr; i++) 
				 {
				 	graphArray[i].X = ((Array[i+1].X-xAnfangswert)*xTeilungPixel/xTeilungWert+Ursprung.X);
					graphArray[i].Y = Ursprung.Y-(float) (Array[i+1].Y*yTeilungPixel/yTeilungWert);
					if(graphArray[i].X < Ursprung.X)
						t++;
				 }
				 try
				 {
				 	 g.DrawCurve(stiftFunk1,graphArray,t,arrayGr-(t+1),0);
				 	 picB.Image=kennlimage;			
				 }
				 catch
				 {
				 	System.Windows.Forms.MessageBox.Show("Das Array muss mindestens 2 Punkte enthalten");
				 }
				 	
						
			 }
			 else
			 	System.Windows.Forms.MessageBox.Show("Der gewählte Diagrammtyp ist kein Zeitdiagramm");
		}
		
		public void Zeitdiagrammzeichnen( PointF [] Array1, PointF [] Array2)
		{
			 if(!koordinaten_OK)
			 	diagrammInit();
			 if(diagrammtyp=="Zeitdiagramm")
			 {
			 	 Image kennlimage = new Bitmap(picB.Width,picB.Height);
				 Graphics g = Graphics.FromImage(kennlimage);
				 //Graphics g = picB.CreateGraphics();
				 stiftFunk1 = new Pen(farbeFunktion1,2);
				 
				 int arrayGr1 = (int) Array1[0].X;
				 int arrayGr2 = (int) Array2[0].X;
				
				 PointF [] graphArray1 = new PointF[arrayGr1];
				 PointF [] graphArray2 = new PointF[arrayGr2];
				 
				 int t1=0;
				 for (int i = 0; i < arrayGr1; i++) 
				 {
				 	graphArray1[i].X = ((Array1[i+1].X-xAnfangswert)*xTeilungPixel/xTeilungWert+Ursprung.X);
					graphArray1[i].Y = Ursprung.Y-(float) (Array1[i+1].Y*yTeilungPixel/yTeilungWert);
					if(graphArray1[i].X < Ursprung.X)
						t1++;
				 }
				 
				 int t2=0;
				 for (int i = 0; i < arrayGr2; i++) 
				 {
				 	graphArray2[i].X = ((Array2[i+1].X-xAnfangswert)*xTeilungPixel/xTeilungWert+Ursprung.X);
					graphArray2[i].Y = Ursprung.Y-(float) (Array2[i+1].Y*yTeilungPixel/yTeilungWert);
					if(graphArray2[i].X < Ursprung.X)
						t2++;
				 }
				 
				 try
				 {
				 	 g.DrawCurve(stiftFunk1,graphArray1,t1,arrayGr1-(t1+1),0);
				 	 stiftFunk1.Color = Color.Blue;
				 	 g.DrawCurve(stiftFunk1,graphArray2,t2,arrayGr2-(t2+1),0);
				 	 picB.Image=kennlimage;			
				 }
				 catch
				 {
				 	System.Windows.Forms.MessageBox.Show("Das Array muss mindestens 2 Punkte enthalten");
				 }
				 	
						
			 }
			 else
			 	System.Windows.Forms.MessageBox.Show("Der gewählte Diagrammtyp ist kein Zeitdiagramm");
		}
		
		public void Zeitdiagrammzeichnen( PointF [] Array, bool scroll_x)
		{
			
			 Image kennlimage = new Bitmap(picB.Width,picB.Height);
			 Graphics g = Graphics.FromImage(kennlimage);
 			
			
			 if(first == true)
			 {
				
			 	diagrammInit();
				first = false;
			 	
			 }
			 if(diagrammtyp=="Zeitdiagramm")
			 {
				 stiftFunk1 = new Pen(farbeFunktion1,2);
				 
				 int arrayGr = (int) Array[0].X;
				 int samples_verschieben=0;
				 int ii=arrayGr;
				 
				 PointF [] graphArray = new PointF[arrayGr];
				 
				 if(((Array[ii].X*xTeilungPixel)/xTeilungWert+Ursprung.X)>picB.Width)
				 {
				 
				 	while(((Array[ii].X*xTeilungPixel)/xTeilungWert+Ursprung.X)>picB.Width)
					 {
					 	ii--;
					 	samples_verschieben++;
					 }
				     
				 	samples_verschieben+=5;
				 	
				     int nsamples=0;
					 for (int i = 0; i < arrayGr-samples_verschieben; i++) 
					 {
					 	graphArray[i].X = ((Array[i+samples_verschieben].X-Array[samples_verschieben].X)*xTeilungPixel/xTeilungWert+Ursprung.X);
						graphArray[i].Y = Ursprung.Y-(float) (Array[i+1+samples_verschieben].Y*yTeilungPixel/yTeilungWert);
						//if(graphArray[i].X < Ursprung.X)
							nsamples++;
					 }
				 	
					 try
					 {
					 	g.DrawCurve(stiftFunk1,graphArray,0,nsamples-1,0);
					 }
					 catch
					 {
					 	System.Windows.Forms.MessageBox.Show("Das Array muss mindestens 2 Punkte enthalten");
					 }
					 	
				 	 
				 }
				 else
				 {
				 	 int t=0;
					 for (int i = 0; i < arrayGr; i++) 
					 {
					 	graphArray[i].X = ((Array[i+1].X-xAnfangswert)*xTeilungPixel/xTeilungWert+Ursprung.X);
						graphArray[i].Y = Ursprung.Y-(float) (Array[i+1].Y*yTeilungPixel/yTeilungWert);
						if(graphArray[i].X < Ursprung.X)
							t++;
					 }
				 
					 try
					 {
					 	g.DrawCurve(stiftFunk1,graphArray,t,arrayGr-(t+1), 0);
				 	 }
					 catch
					 {
					 	System.Windows.Forms.MessageBox.Show("Das Array muss mindestens 2 Punkte enthalten");
					 }
				 	
				 }	
				
				
				 picB.Image=kennlimage;				 
			 }
			 else
			 	System.Windows.Forms.MessageBox.Show("Der gewählte Diagrammtyp ist kein Zeitdiagramm");
		}
		
		public void Amplitudengang_zeichnen( PointF [] Array)
		{
			 if(!koordinaten_OK)
			 	diagrammInit();

			 Graphics g = picB.CreateGraphics();
			
			 stiftFunk1 = new Pen(farbeFunktion1,2);
			 
			 int arrayGr = (int) Array[0].X;
			
			 PointF [] graphArray = new PointF[arrayGr];
			 
			 for (int i = 0; i < arrayGr; i++) 
			 {
			 	graphArray[i].X =(float) ((Math.Log10(Array[i+1].X/startfrequenz))*xTeilungPixel/*xEinteilungwert*/+Ursprung.X);
			 	graphArray[i].Y = Ursprung.Y-(float) (20*Math.Log10(Array[i+1].Y)*yTeilungPixel/yTeilungWert);
			 	
			 }
			
   			 g.DrawCurve(stiftFunk1,graphArray);
   			 
   			
		}
		
		public void Phasengang_zeichnen( PointF [] Array)
		{
			 if(!koordinaten_OK)
			 	diagrammInit();
			 Graphics g = picB.CreateGraphics();
			 stiftFunk1 = new Pen(farbeFunktion1,2);
			 
			 int arrayGr = (int) Array[0].X;
			
			 PointF [] graphArray = new PointF[arrayGr];
			 
			 for (int i = 0; i < arrayGr; i++) 
			 {
			 	graphArray[i].X =(float) ((Math.Log10(Array[i+1].X/startfrequenz))*xTeilungPixel/*xEinteilungwert*/+Ursprung.X);
			 	graphArray[i].Y = Ursprung.Y-(float) (Array[i+1].Y*yTeilungPixel/yTeilungWert);
			 }
			
   			 g.DrawCurve(stiftFunk1,graphArray);
		}
		
		public PointF Cursor_Amplitude_einzeichnen(PointF [] Array,PointF pt)
		{
			
			Font myfont = new Font("Tahoma", 8);
			SolidBrush mybrush = new SolidBrush(Color.Black);
			StringFormat strFormat = new StringFormat(); 
			PointF cursor = new PointF(0f,0f);
			PointF cursret = new PointF(0f,0f);
			
			int i=1;
			
			if((pt.Y==0f && pt.X==0f) || pt.X==0f)
				if(20*Math.Log10(Array[i].Y) > pt.Y)
					while(20*Math.Log10(Array[i].Y) > pt.Y && i<Array[0].X) i++;
				else
					while(20*Math.Log10(Array[i].Y) < pt.Y && i<Array[0].X) i++;
						
			else if(pt.Y==0f)
				while(Array[i].X<pt.X)
					i++;
		
			if(i==Array[0].X && (Array[i].Y > pt.Y+1f || Array[i].Y < pt.Y-1f  ) )
			{
				System.Windows.Forms.MessageBox.Show("Wert nicht gefunden");
			}
			else
			{
				
				cursret.X=Array[i].X;
				cursret.Y=0f;
				Graphics g = picB.CreateGraphics();
				Pen curspen = new Pen(Color.SpringGreen,1);
				 
				cursor.X =(float) ((Math.Log10(Array[i].X/startfrequenz))*xTeilungPixel+Ursprung.X);
				cursor.Y = Ursprung.Y-(float) (20*Math.Log10(Array[i].Y)*yTeilungPixel/yTeilungWert);
				
				string st= String.Format(" \u03C9 = {0:0.0} [1/s]\n|G|= {1:0.00} [dB]",Array[i].X,20*Math.Log10(Array[i].Y));

				
				if(cursor.X > pictureBreite-80)
			 		g.DrawString(st,myfont,mybrush,cursor.X-80, cursor.Y, strFormat);
				else
					g.DrawString(st,myfont,mybrush,cursor.X, cursor.Y, strFormat);
				
				g.DrawLine(curspen,cursor.X,pictureHöhe-rand_Unten,cursor.X,0f);
				
				PointF [] pfeil =  {new PointF (cursor.X, cursor.Y), new PointF(cursor.X-5, cursor.Y-5), new PointF(cursor.X+5, cursor.Y-5), new PointF (cursor.X, cursor.Y)};
				curspen.Width=2;
				g.DrawPolygon(curspen,pfeil);
			}
			
			return cursret;
		}
		
		public void Cursor_Amplitude_einzeichnen(PointF pt)
		{
			
			Font myfont = new Font("Tahoma", 8);
			SolidBrush mybrush = new SolidBrush(Color.WhiteSmoke);
			StringFormat strFormat = new StringFormat(); 
			PointF cursor = new PointF(0f,0f);
			
			Graphics g = picB.CreateGraphics();
			Pen curspen = new Pen(Color.DarkOrchid,1);
			
			
			 
			cursor.X =(float) ((Math.Log10(pt.X/startfrequenz))*xTeilungPixel+Ursprung.X);
			cursor.Y = Ursprung.Y-(float) (20*Math.Log10(pt.Y)*yTeilungPixel/yTeilungWert);
			
			string st= String.Format(" \u03C9 = {0:0.0} [1/s]\n|G|= {1:0.00} [dB]",pt.X,20*Math.Log10(pt.Y));
			
			if(cursor.X > pictureBreite-80)
			{
		 		mybrush.Color = Color.WhiteSmoke;
				g.FillRectangle(mybrush,cursor.X-90, abst_schrift_cursor,90,30);
				mybrush.Color = Color.DarkOrchid;	
				g.DrawString(st,myfont,mybrush,cursor.X-90, abst_schrift_cursor, strFormat);
			}
			else
			{
				mybrush.Color = Color.WhiteSmoke;
				g.FillRectangle(mybrush,cursor.X, abst_schrift_cursor,90,30);
				mybrush.Color = Color.DarkOrchid;	
				g.DrawString(st,myfont,mybrush,cursor.X, abst_schrift_cursor, strFormat);
			}
			
			g.DrawLine(curspen,cursor.X,pictureHöhe-rand_Unten,cursor.X,0f);
			
			PointF [] pfeil =  {new PointF (cursor.X, cursor.Y), new PointF(cursor.X-5, cursor.Y-5), new PointF(cursor.X+5, cursor.Y-5), new PointF (cursor.X, cursor.Y)};
			curspen.Width=2;
			g.DrawPolygon(curspen,pfeil);
				
				
			
		}
		
		public PointF Cursor_Phase_einzeichnen(PointF [] Array,PointF pt)
		{
			
			Font myfont = new Font("Tahoma", 8);
			SolidBrush mybrush = new SolidBrush(Color.Black);
			StringFormat strFormat = new StringFormat(); 
			PointF cursor = new PointF();
			PointF cursret = new PointF();
			
			int i=1;
			
			if((pt.Y==0f && pt.X==0f) || pt.X==0f)
				if(Array[i].Y > pt.Y)
					while(Array[i].Y > pt.Y && i<Array[0].X) i++;
				else
					while(Array[i].Y < pt.Y && i<Array[0].X) i++;
						
			else if(pt.Y==0f)
				while(Array[i].X<pt.X)
					i++;
		
			if(i==Array[0].X && (Array[i].Y > pt.Y+1f || Array[i].Y < pt.Y-1f  ) )  // noch verbessern
			{
				System.Windows.Forms.MessageBox.Show("Wert nicht gefunden"+(Array[i].Y - pt.Y).ToString());
			}
			else
			{
				
				cursret.X=Array[i].X;
				cursret.Y=0f;
				
				Graphics g = picB.CreateGraphics();
				Pen curspen = new Pen(Color.SpringGreen,1);
				 
				cursor.X =(float) ((Math.Log10(Array[i].X/startfrequenz))*xTeilungPixel+Ursprung.X);
				cursor.Y = Ursprung.Y-(float) (Array[i].Y*yTeilungPixel/yTeilungWert);
				
				string st= String.Format(" \u03C9 = {0:0.0} [1/s]\n<G= {1:0.0#}°",Array[i].X,Array[i].Y);

				if(cursor.X > pictureBreite-80)
			 		g.DrawString(st,myfont,mybrush,cursor.X-80, cursor.Y, strFormat);
				else
					g.DrawString(st,myfont,mybrush,cursor.X, cursor.Y, strFormat);
				
				g.DrawLine(curspen,cursor.X,pictureHöhe-rand_Unten,cursor.X,0f);
				
				PointF [] pfeil =  {new PointF (cursor.X, cursor.Y), new PointF(cursor.X-5, cursor.Y-5), new PointF(cursor.X+5, cursor.Y-5), new PointF (cursor.X, cursor.Y)};
				curspen.Width=2;
				g.DrawPolygon(curspen,pfeil);
			}
			
			return cursret;
			
		}
		
		public void Cursor_Phase_einzeichnen(PointF pt)
		{
			
			Font myfont = new Font("Tahoma", 8);
			SolidBrush mybrush = new SolidBrush(Color.Black);
			StringFormat strFormat = new StringFormat(); 
			PointF cursor = new PointF();
			
				
				Graphics g = picB.CreateGraphics();
				Pen curspen = new Pen(Color.DarkOrchid,1);
				 
				cursor.X =(float) ((Math.Log10(pt.X/startfrequenz))*xTeilungPixel+Ursprung.X);
				cursor.Y = Ursprung.Y-(float) (pt.Y*yTeilungPixel/yTeilungWert);
				
				string st= String.Format(" \u03C9 = {0:0.0} [1/s]\n<G= {1:0.0#}°",pt.X,pt.Y);

				if(cursor.X > pictureBreite-80)
				{
					mybrush.Color = Color.WhiteSmoke;
					g.FillRectangle(mybrush,cursor.X-90, abst_schrift_cursor,90,30);
					mybrush.Color = Color.DarkOrchid;
					g.DrawString(st,myfont,mybrush,cursor.X-90, abst_schrift_cursor, strFormat);
				}
			 		
				else
				{
					mybrush.Color = Color.WhiteSmoke;
					g.FillRectangle(mybrush,cursor.X, abst_schrift_cursor,90,30);
					mybrush.Color = Color.DarkOrchid;	
					g.DrawString(st,myfont,mybrush,cursor.X, abst_schrift_cursor, strFormat);
				}
					
				
				g.DrawLine(curspen,cursor.X,pictureHöhe-rand_Unten,cursor.X,0f);
				
				PointF [] pfeil =  {new PointF (cursor.X, cursor.Y), new PointF(cursor.X-5, cursor.Y-5), new PointF(cursor.X+5, cursor.Y-5), new PointF (cursor.X, cursor.Y)};
				curspen.Width=2;
				g.DrawPolygon(curspen,pfeil);
			
			
		
			
		}
		
		public void koordinatensytemZeichnen()
		{
			koordinaten_OK=false;
			diagrammInit();
		}
		
		public void diagrammLöschen()
		{
			Image kennlimage = new Bitmap(picB.Width,picB.Height);
			Graphics g = Graphics.FromImage(kennlimage);
			
			picB.Image=kennlimage;	
			
		}
		
	}
}
