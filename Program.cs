using System;
using Views;
using Controllers;
using Models;

namespace ConsultorioOdontologico
{
    public class Program
    {
        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        // remove one character from the list of password characters
                        password = password.Substring(0, password.Length - 1);
                        // get the location of the cursor
                        int pos = Console.CursorLeft;
                        // move the cursor to the left by one character
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        // replace it with space
                        Console.Write(" ");
                        // move the cursor to the left by one character again
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }

            // add a new line because user pressed enter at the end of their password
            Console.WriteLine();
            return password;
        }

        public static void Main(string[] args)
        {   
            
            
            EspecialidadeController.InsertEspecialidade("Arrancador de dente", "Arrancar dente com alicate");
            DentistaController.InserirDentista("José do Carmo", "111.111.111-11", "47 99999-9999", "jose.carmo@dentista.com", "123456", "12345/SC", 15000, 1);
            PacienteController.InserirPaciente("Amélia da Silva", "111.111.111-11", "47 88888-8888", "amelia.silva@paciente.com", "123456", Convert.ToDateTime("1990-01-01"));
            
            //MenuPrincipal();

            do
            {
                Console.WriteLine("Informe o usuário: ");
                string Email = Console.ReadLine();
                Console.WriteLine("Informe a senha: ");
                string Senha = ReadPassword();
                
                try
                {
                    Auth.Login(Email, Senha);
                    if (Auth.Dentista != null) 
                    {
                        MenuPrincipal();
                    }
                    if (Auth.Paciente != null) 
                    {
                        MenuPaciente();
                    }
                    Auth.Logout();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                }
            } 
            while (!Auth.isLogeed);
        }

        public static void MenuPaciente()
        {
            Console.WriteLine($" ============= BEM VINDO PACIENTE {Auth.Paciente.Nome} ============ ");
            Console.WriteLine("+------------------------------------+");
            Console.WriteLine("| Operação | Descrição               |");
            Console.WriteLine("|----------|-------------------------|");
            Console.WriteLine("|    0     | Sair                    |");
            Console.WriteLine("|    1     | Visualizar Agendamentos |");
            Console.WriteLine("|    2     | Confirmar Agendamentos  |");
            Console.WriteLine("+------------------------------------+");
            int opt = 0;

            do
            {
                Console.WriteLine("Digite a operação: ");
                try
                {
                    opt = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    opt = 99;
                }
                switch (opt)
                {
                    case 0:
                        Console.WriteLine("Obrigado por utilizar o sistema");
                        break;
                    case 1:
                        AgendamentoView.GetAgendamentosPorPaciente(Auth.Paciente.Id);
                        break;
                    case 2:
                        AgendamentoView.ConfirmarAgendamento();
                        break;
                    default:
                        Console.WriteLine("Operação inválida");
                        break;
                }  
            } 
            while(opt != 0);
        }

        public static void MenuPrincipal()
        {
            Console.WriteLine(" ============= BEM VINDO ============ ");
            Console.WriteLine("+------------------------------------+");
            Console.WriteLine("| Operação | Descrição               |");
            Console.WriteLine("|----------|-------------------------|");
            Console.WriteLine("| 0        | Sair                    |");
            Console.WriteLine("| 1        | Incluir Dentista        |");
            Console.WriteLine("| 2        | Incluir Paciente        |");
            Console.WriteLine("| 3        | Incluir Sala            |");
            Console.WriteLine("| 4        | Incluir Agendamento     |");
            Console.WriteLine("| 5        | Alterar Dentista        |");
            Console.WriteLine("| 6        | Alterar Paciente        |");
            Console.WriteLine("| 7        | Alterar Sala            |");
            Console.WriteLine("| 8        | Alterar Agendamento     |");
            Console.WriteLine("| 9        | Excluir Dentista        |");
            Console.WriteLine("| 10       | Excluir Paciente        |");
            Console.WriteLine("| 11       | Excluir Sala            |");
            Console.WriteLine("| 12       | Excluir Agendamento     |");
            Console.WriteLine("| 13       | Visualizar Dentistas    |");
            Console.WriteLine("| 14       | Visualizar Pacientes    |");
            Console.WriteLine("| 15       | Visualizar Salas        |");
            Console.WriteLine("| 16       | Visualizar Agendamentos |");
            Console.WriteLine("| 17       | Incluir Especialidade   |");
            Console.WriteLine("| 18       | Alterar Especialidade   |");
            Console.WriteLine("| 19       | Excluir Especialidade   |");
            Console.WriteLine("| 20       | Visualizar Especialidade|");
            Console.WriteLine("| 21       | Incluir Procedimento    |");
            Console.WriteLine("| 22       | Alterar Procedimento    |");
            Console.WriteLine("| 23       | Excluir Procedimento    |");
            Console.WriteLine("| 24       | Visualizar Procedimento |");
            Console.WriteLine("| 25       | Incluir Agen. Procedi.  |");
            Console.WriteLine("| 26       | Alterar Agen. Procedi.  |");
            Console.WriteLine("| 27       | Excluir Agen. Procedi.  |");
            Console.WriteLine("| 28       | Visualizar Agen. Procedi|");
            Console.WriteLine("+------------------------------------+");

            int opt = 0;

            do
            {
                try
                {
                    Console.WriteLine("Digite a operação: ");
                    opt = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    opt = 99;
                }
                try
                {
                    switch (opt)
                    {
                        case 0:
                        {
                            try
                            {
                                Console.WriteLine("Obrigado por utilizar o sistema!");
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de inserir Especialidades");
                            }
                            break;
                        }
                        case 1:
                        {
                            try
                            {
                                DentistaView.InserirDentista();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de inserir Dentista");
                            }
                            break;
                        }
                        case 2:
                        {
                            try
                            {
                                PacienteView.InserirPaciente();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de inserir Paciente");
                            }
                            break;
                        }
                        case 3:
                        {
                            try
                            {
                                SalaView.InserirSala();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de inserir Sala");
                            }
                            break;
                        }
                        case 4:
                        {
                            try
                            {
                                AgendamentoView.InserirAgendamento();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de inserir Agendamento");
                            }
                            break;
                        }
                        case 5:
                        {
                            try
                            {
                                DentistaView.AlterarDentista();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de alterar Dentista");
                            }
                            break;
                        }
                        case 6:
                        {
                            try
                            {
                                PacienteView.AlterarPaciente();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de alterar Paciente");
                            }
                            break;
                        }
                        case 7:
                        {
                            try
                            {
                                SalaView.AlterarSala();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de alterar Sala");
                            }
                            break;
                        }
                        case 8:
                        {
                            try
                            {
                                AgendamentoView.AlterarAgendamento();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de alterar Agendamento");
                            }
                            break;
                        }
                        case 9:
                        {
                            try
                            {
                                DentistaView.ExcluirDentista();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de exlcuir Dentista");
                            }
                            break;
                        }
                        case 10:
                        {
                            try
                            {
                                PacienteView.ExcluirPaciente();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de exlcuir Paciente");
                            }
                            break;
                        }
                        case 11:
                        {
                            try
                            {
                                SalaView.ExcluirSala();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de exlcuir Sala");
                            }
                            break;
                        }
                        case 12:
                        {
                            try
                            {
                                AgendamentoView.ExcluirAgendamento();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de exlcuir Agendamento");
                            }
                            break;
                        }
                        case 13:
                        {
                            try
                            {
                                DentistaView.ListarDentistas();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de listar Dentista");
                            }
                            break;
                        }
                        case 14:
                        {
                            try
                            {
                                PacienteView.ListarPacientes();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de listar Paciente");
                            }
                            break;
                        }
                        case 15:
                        {
                            try
                            {
                                SalaView.ListarSalas();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de listar Salas");
                            }
                            break;
                        }
                        case 16:
                        {
                            try
                            {
                                AgendamentoView.ListarAgendamentos();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de listar Agendamentos");
                            }
                            break;
                        }
                        case 17:
                        {
                            try
                            {
                                EspecialidadeViews.InserirEspecialidade();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de inserir Especialidades");
                            }
                            break;
                        }
                        case 18:
                        {
                            try
                            {
                                EspecialidadeViews.AlterarEspecialidade();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de alterar Especialidades");
                            }
                            break;
                        }
                        case 19:
                        {
                            try
                            {
                                EspecialidadeViews.ExcluirEspecialidade();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de excluir Especialidades");
                            }
                            break;
                        }
                        case 20:
                        {
                            try
                            {
                                EspecialidadeViews.ListarEspecialidades();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de listar Especialidades");
                            }
                            break;
                        }
                        case 21:
                        {
                            try
                            {
                                ProcedimentoViews.InserirProcedimentos();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de inserir Procedimento");
                            }
                            break;
                        }
                        case 22:
                        {
                            try
                            {
                                ProcedimentoViews.AlterarProcedimentos();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de alterar Procedimento");
                            }
                            break;
                        }
                        case 23:
                        {
                            try
                            {
                                ProcedimentoViews.ExcluirProcedimentos();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de excluir Procedimento");
                            }
                            break;
                        }
                        case 24:
                        {
                            try
                            {
                                ProcedimentoViews.ListarProcedimentos();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de listar Procedimento");
                            }
                            break;
                        }
                        case 25:
                        {
                            try
                            {
                                AgendamentoProcedimentoViews.InserirAgendamentoProcedimento();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de inserir AgendamentoProcedimento");
                            }
                            break;
                        }
                        case 26:
                        {
                            try
                            {
                                AgendamentoProcedimentoViews.AlterarAgendamentoProcedimento();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de alterar AgendamentoProcedimento");
                            }
                            break;
                        }
                        case 27:
                        {
                            try
                            {
                                AgendamentoProcedimentoViews.ExlcuirAgendamentoProcedimento();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de excluir AgendamentoProcedimento");
                            }
                            break;
                        }
                        case 28:
                        {
                            try
                            {
                                AgendamentoProcedimentoViews.ListarAgendamentoProcedimento();
                            }
                            catch(Exception)
                            {
                                throw new Exception ("Erro ao chamar a função de listar AgendamentoProcedimento");
                            }
                            break;
                        }
                        
                        default:
                        {
                            Console.WriteLine("Operação inválida");
                            break;
                        }
                    }
                } 
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    opt = 99;
                }
            } while (opt != 0);
        }
    }
}
