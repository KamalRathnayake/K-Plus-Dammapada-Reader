using System;
using System.Windows;
using DammapadaReader.ViewModel;
using DammapadaReader.Model.Domain;
using DammapadaReader.Model.Abstract;
using DammapadaReader.Model.Concrete;
using System.IO;

namespace DammapadaReader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel viewModel;
        IRepository<Vagga> VaggaRepository = new BinaryChapterRepository();
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainWindowViewModel();
            this.DataContext = viewModel;
            chapter.MouseDown += (sn, ev) => { viewModel.ChapterName = "dedede"; };
            Loaded += (sn, ev) => { viewModel.Vaggas = new System.Collections.ObjectModel.ObservableCollection<Vagga>(); foreach (var v in VaggaRepository.Items) viewModel.Vaggas.Add(v); chaptersCombo.ItemsSource = viewModel.Vaggas; };
            chaptersCombo.SelectionChanged += (sn, ev) =>
            {
                versesCombo.Items.Clear(); (chaptersCombo.SelectedItem as Vagga).Stanzas.ForEach(x => versesCombo.Items.Add(x));
                chapter.Text = (chaptersCombo.SelectedItem as Vagga).Name;
            };
            versesCombo.SelectionChanged += (sn, ev) =>
            {
                string css = @"<style>
	                            body{
		                            background-color:#EAEAEA;
	                            }
	                            blockquote{
		                            font-family:'segoe ui';
	                            }
                            </style>
                            ";
                if (versesCombo.SelectedIndex >= 0)
                {
                    browserWindow.NavigateToString(css + File.ReadAllText((versesCombo.SelectedItem as Stanza).HTML));

                    verse.Text = versesCombo.SelectedItem.ToString();
                }
            };

            chaptersCombo.SelectedIndex = 0;
            versesCombo.SelectedIndex = 0;
        }
    }
}