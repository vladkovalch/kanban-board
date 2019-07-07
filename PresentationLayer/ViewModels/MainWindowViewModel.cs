using AutoMapper;
using BusinessLogicLayer;
using BusinessLogicLayer.DTO;
//using PresentationLayer.BoardService;
//using PresentationLayer.CardService;
//using PresentationLayer.ListService;
//using PresentationLayer.UserProfileService;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PresentationLayer.AuthorizationService;

namespace PresentationLayer.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        //BoardMgmtContractClient boardMgmtContract = new BoardMgmtContractClient();
        //ListMgmtContractClient listMgmtContract = new ListMgmtContractClient();
        //CardMgmtContractClient cardMgmtContract = new CardMgmtContractClient();
        AuthorizationContractClient authorization = new AuthorizationContractClient();
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
        }
        void GetUser()
        {
            Task task;
            LoaderVisible = true;
            task = new Task(() =>
            {
                try
                {
                    BusinessLogicLayer.DTO.UserDTO userDTO = null;
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
            BusinessLogicLayer.DTO.BoardDTO[] boardsDTO = null;
            Task task = new Task(() =>
            {
                try
                {
                   // boardsDTO = (type == nameof(User.Boards)) ?
                   //boardMgmtContract.FindBoardById(User.Id): 0;

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
            BusinessLogicLayer.DTO.ListDTO[] listDTO = null;
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
            BusinessLogicLayer.DTO.CardDTO[] cardsDTO = null;
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
        void LoadCurrentBoard()
        {
            if (CurBoard == null)
                return;

            LoaderVisible = true;
            Task.Run(() =>
            {
                try
                {
                    
                   //// ListDTO[] listsDTO = new ListService.ListMgmtContractClient().GetAllLists();
                   // if (listsDTO == null || listsDTO.Length == 0)
                   //     return;
                   // App.Current.Dispatcher.Invoke(() =>
                   // {
                   //     CurBoard.Lists.Clear();
                   //     foreach (var col in listsDTO)
                   //     {
                   //         ListModel columnModel = Mapper.Map<ListModel>(col);
                   //         columnModel.MainWindow = _mainWindow;
                   //         CurBoard.Lists.Add(columnModel);
                   //     }
                   // });

                   // //load cards
                   // foreach (var col in CurBoard.Lists)
                   // {
                   //     CardDTO[] cardsDTO = new CardService.CardMgmtContractClient().GetAllCards();
                   //     if (cardsDTO != null && cardsDTO.Length > 0)
                   //     {
                   //         App.Current.Dispatcher.Invoke(() =>
                   //         {
                   //             col.Cards.Clear();
                   //             foreach (var card in cardsDTO)
                   //             {
                   //                 CardModel cardModel = Mapper.Map<CardModel>(card);
                   //                 cardModel.ListId = col.Id;
                   //                 cardModel.BoardId = CurBoard.Id;
                   //                 col.Cards.Add(cardModel);
                   //             }
                   //         });
                   //     }
                    //}
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

        //CALLBACKS
        void AddNewCard(AuthorizationService.CardDTO card, int colId)
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

        void EditCardCallback(BusinessLogicLayer.DTO.CardDTO cardDTO)
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

        void AddColumnCallback(BusinessLogicLayer.DTO.ListDTO columnDTO)
        {
            ListModel col = Mapper.Map<ListModel>(columnDTO);
           
            col.MainWindow = _mainWindow;
            CurBoard.Lists.Add(col);
        }


        void ParticipantAddedCallback(BusinessLogicLayer.DTO.UserDTO userDTO)
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
