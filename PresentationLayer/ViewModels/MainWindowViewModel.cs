using AutoMapper;
using BusinessLogicLayer;
using BusinessLogicLayer.DTO;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PresentationLayer.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        BoardModel _curBoard;
        public BoardModel CurBoard
        {
            get { return _curBoard; }
            set
            {
                _curBoard = value;
                OnPropertyChanged(nameof(CurBoard));
            }
        }

        bool _loaderVisible;
        public bool LoaderVisible
        {
            get => _loaderVisible;
            set
            {
                _loaderVisible = value;
                OnPropertyChanged(nameof(LoaderVisible));
            }
        }

        UserModel _user;
        public UserModel User
        {
            get => _user;
            set
            {
                _user = value;
                OnPropertyChanged(nameof(User));
            }
        }

        Window _mainWindow;
        public MainWindowViewModel(Window mainWindow)
        {
           
            _mainWindow = mainWindow;
            //MapperConfigurator.Configure();

           
           
        }
        void GetUser()
        {
            Task task;
            LoaderVisible = true;
            task = new Task(() =>
            {
                try
                {
                    UserDTO userDTO = null;
                    if (userDTO != null)
                    {
                        User.Id = userDTO.Id;
                        User.Email = userDTO.Email;
                        User.Email = userDTO.Email;
                        GetBoards(nameof(User.Boards));
                       
                    }
                    else
                        MessageBox.Show("Cant load user");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + "\n" + e.StackTrace, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                LoaderVisible = false;
            });
            task.Start();
            task.Wait();
        }


        void GetBoards(string type)
        {
            LoaderVisible = true;
            BoardDTO[] boardsDTO = null;
            Task task = new Task(() =>
            {
                try
                {
                    // boardsDTO = (type == nameof(User.PartBoards)) ?
                    //NetProxy.DataExchProxy.GetParticipatedBoards(NetProxy.Token, User.Id) :
                    //NetProxy.DataExchProxy.GetBoards(NetProxy.Token, User.Id);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + "\n" + e.StackTrace, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                LoaderVisible = false;
            });
            task.Start();
            task.Wait();

            if (boardsDTO != null)
            {
                switch (type)
                {
                    case nameof(User.Boards):
                        User.Boards.Clear();
                        foreach (var boardDTO in boardsDTO)
                        {
                            BoardModel board = Mapper.Map<BoardModel>(boardDTO);
                            
                            User.Boards.Add(board);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        void GetColumns(int id)
        {
            LoaderVisible = true;
            ListDTO[] listDTO = null;
            Task task = new Task(() =>
            {
                try
                {
                   // listDTO = NetProxy.DataExchProxy.GetColumns(NetProxy.Token, id);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + "\n" + e.StackTrace, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                LoaderVisible = false;
            });
            task.Start();
            task.Wait();

            if (listDTO != null)
            {
                CurBoard.Lists.Clear();
                foreach (var col in listDTO)
                {
                    CurBoard.Lists.Add(Mapper.Map<ListModel>(col));
                }
            }
        }

        void GetColumnCards(int id)
        {
            LoaderVisible = true;
            CardDTO[] cardsDTO = null;
            Task task = new Task(() =>
            {
                try
                {
                    //cardsDTO = NetProxy.DataExchProxy.GetCards(NetProxy.Token, id);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + "\n" + e.StackTrace, "Error!",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                LoaderVisible = false;
            });
            task.Start();
            task.Wait();

            if (cardsDTO != null)
            {
                ListModel col = CurBoard.Lists.Where(x => x.Id == id).FirstOrDefault();
                if (col == null)
                    return;
                col.Cards.Clear();
                foreach (var card in cardsDTO)
                {
                    col.Cards.Add(Mapper.Map<CardModel>(card));
                }
            }
        }

        void GetParticipants()
        {
            //try
            //{
            //    UserDTO[] partsDTO = NetProxy.DataExchProxy.GetParticipants(NetProxy.Token, CurBoard.Id);
            //    if (partsDTO != null)
            //    {
            //        App.Current.Dispatcher.Invoke(() =>
            //        {
            //            CurBoard.Users.Clear();
            //            foreach (var part in partsDTO)
            //                CurBoard.Users.Add(Mapper.Map<UserModel>(part));
            //        });
            //    }
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message + "\n" + e.StackTrace, "Error!",
            //        MessageBoxButton.OK, MessageBoxImage.Error);
            //}
        }

        void LoadCurrentBoard()
        {
            if (CurBoard == null)
                return;

            LoaderVisible = true;
            Task.Run(() =>
            {
                //try
                //{
                //    //NetProxy.Configure();
                //    ListDTO[] listsDTO = NetProxy.DataExchProxy.GetColumns(NetProxy.Token, CurBoard.Id);
                //    if (listsDTO == null || listsDTO.Length == 0)
                //        return;
                //    App.Current.Dispatcher.Invoke(() =>
                //    {
                //        CurBoard.Lists.Clear();
                //        foreach (var col in listsDTO)
                //        {
                //            ListModel columnModel = Mapper.Map<ListModel>(col);
                //            columnModel.MainWindow = _mainWindow;
                //            CurBoard.Lists.Add(columnModel);
                //        }
                //    });
                   
                //    //load cards
                //    foreach (var col in CurBoard.Lists)
                //    {
                //        CardDTO[] cardsDTO = NetProxy.DataExchProxy.GetCards(NetProxy.Token, col.Id);
                //        if (cardsDTO != null && cardsDTO.Length > 0)
                //        {
                //            App.Current.Dispatcher.Invoke(() =>
                //            {
                //                col.Cards.Clear();
                //                foreach (var card in cardsDTO)
                //                {
                //                    CardModel cardModel = Mapper.Map<CardModel>(card);
                //                    cardModel.ListId = col.Id;
                //                    cardModel.BoardId = CurBoard.Id;
                //                    col.Cards.Add(cardModel);
                //                }
                //            });
                //        }
                //    }
                //}
                //catch (Exception e)
                //{
                //    MessageBox.Show(e.Message + "\n" + e.StackTrace, "Error!",
                //         MessageBoxButton.OK, MessageBoxImage.Error);
                //}
                //finally
                //{
                //    LoaderVisible = false;
                //}
            });

        }

        //CALLBACKS
        void AddNewCard(CardDTO card, int colId)
        {
            ListModel col = CurBoard.Lists.Where(c => c.Id == colId).FirstOrDefault();
            if (col != null)
            {
                CardModel cardModel = Mapper.Map<CardModel>(card);
                cardModel.ListId = colId;
                cardModel.BoardId = CurBoard.Id;
                col.Cards.Add(cardModel);
            }
        }

        void MoveCardCallback(int cardId, int originalColumnId, int destinationColumnId)
        {
            LoaderVisible = true;
            Task.Run(() =>
            {
                try
                {
                    ListModel col = CurBoard.Lists.Where(c => c.Id == originalColumnId).FirstOrDefault();
                    ListModel destcol = CurBoard.Lists.Where(c => c.Id == destinationColumnId).FirstOrDefault();
                    CardModel card = col.Cards.Where(c => c.Id == cardId).FirstOrDefault();

                    if (col == null || destcol == null || card == null)
                        return;
                    App.Current.Dispatcher.Invoke(() =>
                    {
                        col.Cards.Remove(card);
                        destcol.Cards.Add(card);
                    });
                    card.ListId = destcol.Id;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + "\n" + e.StackTrace, "Error!",
                         MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    LoaderVisible = false;
                }
            });
        }

        void EditCardCallback(CardDTO cardDTO)
        {
            CardModel cardModel = null;
            foreach (var col in CurBoard.Lists)
            {
                cardModel = col.Cards.Where(c => c.Id == cardDTO.Id).FirstOrDefault();
                if (cardModel != null)
                    break;
            }
            if (cardModel == null)
                return;

            cardModel.Name = cardDTO.Name;
            cardModel.CreationTime = cardDTO.CreationTime;
        }

        void AddColumnCallback(ListDTO columnDTO)
        {
            ListModel col = Mapper.Map<ListModel>(columnDTO);
            //col.MoveCardAct = MoveCard;
            col.MainWindow = _mainWindow;
            CurBoard.Lists.Add(col);
        }


        void ParticipantAddedCallback(UserDTO userDTO)
        {
            UserModel userModel = Mapper.Map<UserModel>(userDTO);
            if (userModel != null)
                CurBoard.Users.Add(userModel);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
