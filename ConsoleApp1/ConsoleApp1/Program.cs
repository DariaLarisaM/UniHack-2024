using System;
using System.IO.Ports;
using System.Reflection;
using System.Threading;
using NAudio.Wave;

class Program
{
    static SerialPort serialPort;
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        // Specifică portul și rata de baud
        string portCom = "COM3";  // Schimbă cu portul corect al Arduino-ului
        int baudRate = 9600;

        // Crează obiectul SerialPort
        serialPort = new SerialPort(portCom, baudRate);
        bool sunet = true;

        try
        {
            // Deschide conexiunea la portul serial
            serialPort.Open();

            // Afișează meniul principal
            ShowMenu();

            if (sunet == true)
            {
                PlaySound("butonsunet2.wav");
                sunet = false;
            }

            // Buclă infinită care citește datele continuu
            while (true)
            {
                // Verifică dacă sunt date de citit
                if (serialPort.BytesToRead > 0)
                {
                    
                    string choice = serialPort.ReadLine().Trim();

                    switch (choice)
                    {
                        case "optiune1":
                            Console.WriteLine("\nSelectati, va rog, din lista cu cladirile pe care doriti sa le vizitati.");
                            PlaySound("alegecladiri.wav");
                            ShowBuildingOptions();
                            int x=1;
                            while(x<=3)
                            {
                                string varianta = serialPort.ReadLine().Trim();
                                if (varianta == "catedrala")
                                {
                                    Console.WriteLine("\n Catedrala Mitropolitana Ortodoxa");
                                    PlaySound("butoncatedrala.wav");
                                }

                                if (varianta == "huniade")
                                {
                                    Console.WriteLine("\n Muzeul Castelul Huniade");
                                    PlaySound("butonhuniade.wav");
                                }

                                if (varianta == "muzeu")
                                {
                                    Console.WriteLine("\n Muzeul de Arta din Timisoara");
                                    PlaySound("butonmuzeu.wav");
                                }

                                if (varianta == "bastion")
                                {
                                    Console.WriteLine("\n Bastionul Maria Theresa");
                                    PlaySound("butonbastion.wav");
                                }
                                    x++;
                            }
                            Console.WriteLine("\nAm realizat un traseu optim pentru dvs!\n");
                            PlaySound("traseuoptim.wav");
                            Console.WriteLine("\nDaca doriti sa faceti o plimbare, deplasati-va inspre nord-est, trecand prin Centru Timisoara, Piata Libertatii, Piata Unirii, regasind in zona toate punctele!\n");
                            Thread.Sleep(100);
                            Console.WriteLine("\nDaca doriti sa va deplasati cu ajutorul mijloacelor de transport in comun, puteti lua din statia Catedrala, unul din tramvaiele 1(5 min.), 2(10 min.), 6a(7 min.), mergeti 4 statii, iar mai apoi mai aveti de mers 350m inspre nord, pentru a ajunge la destinatie.\n");
                            Console.WriteLine();
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Daca doriti alta optiune, alegeti A sau B.");
                            PlaySound("altaoptiune.wav");
                            Console.WriteLine();
                            Console.WriteLine("-----------------------------------------------");
                            break;

                        case "optiune2":
                            // Afișează lista de clădiri disponibile
                            Console.WriteLine("Selectati o cladire pentru informatii suplimentare:");
                            PlaySound("apasacladireinfo.wav");
                            ShowBuildingOptions();
                            string alegere = serialPort.ReadLine().Trim();
                            if (alegere == "catedrala")
                            {
                                Console.WriteLine("\nCatedrala Mitropolitana Ortodoxa");
                                PlaySound("butoncatedrala.wav");
                                Console.WriteLine();
                                Console.Write("\nCatedrala Mitropolitana din Timisoara este una dintre cele mai frumoase si impresionante cladiri religioase din Romania, un reper iconic al orasului si o atractie turistica majora. Ridicata intre 1936 si 1941 in stil neo-moldovenesc, catedrala imbina elemente traditionale romanesti cu influente bizantine, creand o armonie arhitecturala captivanta.\n");
                                Console.Write("\n");
                                Console.Write("Situata in inima orasului, pe Bulevardul Regele Ferdinand I, catedrala se remarca prin turnurile sale inalte de 83 de metri, decorate cu motive geometrice si cruci elegante, care pot fi vazute de la mari distante. Interiorul, decorat cu picturi murale si iconografie deosebita, invita turistii sa descopere frumusetea si spiritualitatea ortodoxiei romanesti. In plus, cripta catedralei adaposteste mormintele unor mitropoliti de seama, iar colectia de obiecte religioase si de arta veche din muzeul sau este unica in zona.\n");
                                Console.Write("\n");
                                Console.Write("Inconjurata de parcuri si cladiri istorice, Catedrala Mitropolitana ofera o experienta unica celor care ii trec pragul, fiind nu doar un loc de reculegere, ci si un spatiu cultural de mare importanta.\n");
                                Console.Write("\n");
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine();
                                Console.WriteLine("Daca doriti alta optiune, alegeti A sau B.");
                                PlaySound("altaoptiune.wav");
                                Console.WriteLine();
                                Console.WriteLine("-----------------------------------------------");
                            }
                            if (alegere == "huniade")
                            {
                                Console.WriteLine("\nMuzeul Castelul Huniade");
                                PlaySound("butonhuniade.wav");
                                Console.WriteLine();
                                Console.Write("\nMuzeul Castelul Huniade din Timisoara este un loc fascinant unde istoria, cultura si arhitectura se imbina intr-un mod impresionant. Situat in centrul orasului, acest castel medieval este considerat unul dintre cele mai vechi si importante monumente istorice din vestul Romaniei, datand din secolul al XV-lea. Initial construit ca fortificatie de aparare, castelul a fost transformat in muzeu in 1875 si gazduieste colectii valoroase care ilustreaza evolutia orasului si a regiunii Banat.\n");
                                Console.Write("\n");
                                Console.Write("Vizitatorii pot explora expozitii ce acopera o gama larga de teme, de la arheologie si istorie medievala, pana la stiinte naturale si artizanat traditional. Printre cele mai remarcabile atractii se numara colectiile de monede, arme medievale, si descoperirile arheologice din perioada romana. De asemenea, castelul ofera o privire unica asupra arhitecturii medievale, cu ziduri impunatoare si turnuri ce aduc aminte de vremurile in care a fost sediul unor voivozi si conducatori locali.\n");
                                Console.Write("\n");
                                Console.Write("Muzeul Castelul Huniade este un loc perfect pentru iubitorii de istorie si cultura, oferind o calatorie captivanta prin timp, in inima unei cladiri istorice cu o poveste fascinanta.\n");
                                Console.Write("\n");
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine();
                                Console.WriteLine("Daca doriti alta optiune, alegeti A sau B.");
                                PlaySound("altaoptiune.wav");
                                Console.WriteLine();
                                Console.WriteLine("-----------------------------------------------");
                            }
                            if (alegere == "muzeu")
                            {
                                Console.WriteLine("\nMuzeul de Arta din Timisoara");
                                PlaySound("butonmuzeu.wav");
                                Console.WriteLine();
                                Console.Write("\nMuzeul de Arta din Timisoara este o destinatie de neratat pentru iubitorii de cultura si arta, fiind unul dintre cele mai importante institutii de acest tip din vestul Romaniei. Situat in Palatul Baroc, o cladire impresionanta din centrul orasului, muzeul gazduieste o colectie valoroasa de lucrari de arta, care acopera o perioada ce se intinde de la Renastere pana in perioada contemporana. Vizitatorii pot admira opere semnate de mari artisti romani si europeni, inclusiv picturi, sculpturi, grafica si arte decorative.\n");
                                Console.Write("\n");
                                Console.Write("Muzeul ofera o experienta fascinanta, de la galeriile sale care includ lucrari de Renastere si Baroc, pana la expozitii ce reflecta diversitatea artei moderne si contemporane. De asemenea, muzeul gazduieste periodic expozitii temporare, ce aduc in prim-plan atat artisti consacrati, cat si tineri talentati. Cu arhitectura sa eleganta si atmosfera plina de istorie, Muzeul de Arta din Timisoara este un loc ideal pentru a explora mostenirea culturala a regiunii si a descoperi capodoperele artistice din diverse perioade istorice.\n");
                                Console.Write("\n");
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine();
                                Console.WriteLine("Daca doriti alta optiune, alegeti A sau B.");
                                PlaySound("altaoptiune.wav");
                                Console.WriteLine();
                                Console.WriteLine("-----------------------------------------------");
                            }
                            if (alegere == "bastion")
                            {
                                Console.WriteLine("\nBastionul Maria Theresa");
                                PlaySound("butonbastion.wav");
                                Console.WriteLine();
                                Console.Write("\nBastionul Maria Theresa din Timisoara este o atractie turistica impresionanta, ce ofera o incursiune in istoria si arhitectura fortificatiilor medievale. Construit in secolul XVIII, in perioada habsburgica, bastionul face parte din fostul sistem de aparare al orasului si este un simbol al dezvoltarii Timisoarei ca fort militar. Cu ziduri masive si turnuri ce au supravietuit vremurilor, bastionul a fost restaurat cu grija si transformat intr-un loc de vizitat, fiind ideal pentru iubitorii de istorie si arhitectura.\n");
                                Console.Write("\n");
                                Console.Write("Astazi, Bastionul Maria Theresa gazduieste mai multe muzee si expozitii de artizanat, iar parcul din jur ofera o atmosfera placuta pentru plimbari. Vizitatorii pot explora diverse galerii dedicate artei si traditiilor locale, dar si sa invete despre istoria orasului si rolul pe care l-a jucat acest bastion in protejarea Timisoarei de invadatori. Cu o locatie centrala si un farmec deosebit, Bastionul Maria Theresa este un loc perfect pentru a descoperi trecutul Timisoarei intr-un cadru istoric deosebit.\n");
                                Console.Write("\n");
                                Console.WriteLine("-----------------------------------------------");
                                Console.WriteLine();
                                Console.WriteLine("Daca doriti alta optiune, alegeti A sau B.");
                                PlaySound("altaoptiune.wav");
                                Console.WriteLine();
                                Console.WriteLine("-----------------------------------------------");
                            }
                            break;

                        case "sunet": break;

                        default:
                            ShowMenu();  // Reafișează meniul pentru o alegere validă
                            break;
                    }
                }

                // Adaugă o mică pauză pentru a nu suprasolicita procesorul
                Thread.Sleep(50);  // Așteaptă 50ms înainte de a verifica din nou portul serial
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Eroare: " + ex.Message);  // Afișează eroarea în consola
        }
        finally
        {
            // Închide portul serial când aplicația se închide
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                Console.WriteLine("Portul serial a fost închis.");
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine("***********************************************");
        Console.WriteLine("          BUNA ZIUA! Bine ati venit in         ");
        Console.WriteLine("             Get To Know Timisoara             ");
        Console.WriteLine("***********************************************");


        // Împărțim textul pe secțiuni clare
        Console.WriteLine();
        Console.WriteLine("Cu ce va putem ajuta astăzi?");
        Console.WriteLine();
        Console.WriteLine("A. Doresc un traseu optim de vizitat.");
        Console.WriteLine("B. Doresc informatii despre o cladire specifica.");
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------");

    }

    static void ShowBuildingOptions()
    {
        Console.WriteLine("\n1. Catedrala Mitropolitana Ortodoxa");
        Console.WriteLine("2. Muzeul Castelul Huniade");
        Console.WriteLine("3. Muzeul National de Arta Timisoara");
        Console.WriteLine("4. Bastionul Maria Theresa");
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------");
    }

    static void PlaySound(string filePath)
    {
        using (var audioFile = new AudioFileReader(filePath))
        using (var outputDevice = new WaveOutEvent())
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            while (outputDevice.PlaybackState == PlaybackState.Playing)
            {
                // Așteaptă până când sunetul s-a terminat
                Thread.Sleep(100);
            }
        }
    }
}
