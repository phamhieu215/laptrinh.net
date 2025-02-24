using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using cuoiki.Models;

namespace cuoiki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        QlbanHangContext db = new QlbanHangContext();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiDuLieu();
            var queryCombo = from lsp in db.LoaiSanPhams
                             select lsp;
            cboLoai.ItemsSource = queryCombo.ToList();
            cboLoai.DisplayMemberPath = "TenLoai";
            cboLoai.SelectedValuePath = "Maloai";
            cboLoai.SelectedIndex = 0;
        }

        private void HienThiDuLieu()
        {
            var sanPhamQuery = from sp in db.SanPhams
                               select new
                               {
                                   sp.MaSp,
                                   sp.TenSp,
                                   sp.MaLoaiNavigation.TenLoai,
                                   sp.DonGia,
                                   sp.SoLuong,
                                   ThanhTien = sp.DonGia * sp.SoLuong
                               };
            dtgNhanVien.ItemsSource = sanPhamQuery.ToList();
        }

        private void btnNhap_Click(object sender, RoutedEventArgs e)
        {
            if (isCheck() == true)
            {
                
                SanPham spMoi = new SanPham();
                spMoi.MaSp = txtMa.Text;
                spMoi.TenSp = txtName.Text;
                spMoi.MaLoai = cboLoai.SelectedValue?.ToString();
                //spMoi.MaLoai = cboLoai.SelectedValue.ToString();
                spMoi.DonGia = int.Parse(txtDonGia.Text);
                spMoi.SoLuong = int.Parse(txtSoLuong.Text);
                db.SanPhams.Add(spMoi);
                db.SaveChanges();
                HienThiDuLieu();
            }
        }
        private bool isCheck()
        {
            if (txtMa.Text == "" || txtName.Text == "" || txtDonGia.Text == "" || txtSoLuong.Text == "")
            {
                MessageBox.Show("ban phai nhap tat ca du lieu", "Them", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            var querySua = from sp in db.SanPhams
                           where sp.MaSp == txtMa.Text
                           select sp;
            SanPham spSua = querySua.FirstOrDefault();
            if (spSua != null)
            {

                if (isCheckSua() == true)
                {
                    spSua.TenSp = txtName.Text;
                    spSua.MaLoai = cboLoai.SelectedValue?.ToString();
                    spSua.SoLuong = int.Parse(txtSoLuong.Text);
                    spSua.DonGia = int.Parse(txtDonGia.Text);
                }
            }
            db.SaveChanges();
            HienThiDuLieu();
        }
        private bool isCheckSua()
        {
            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("ban phai nhap so luong la so nguyen va >0", "sua",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (!int.TryParse(txtDonGia.Text, out int donGia) || donGia <= 0)
            {
                MessageBox.Show("ban phai don gia la so nguyen va >0", "sua",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            var queryXoa = from sp in db.SanPhams
                           where sp.MaSp == txtMa.Text
                           select sp;
            SanPham spXoa = queryXoa.FirstOrDefault();
            if (spXoa != null)
            {
                    MessageBoxResult tl = MessageBox.Show("ban muon xoa", "xoa", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (tl == MessageBoxResult.Yes)
                    {
                        db.SanPhams.Remove(spXoa);
                        db.SaveChanges();
                        HienThiDuLieu();
                    }
                
            }
            else
            {
                MessageBox.Show("khong có sp muon xoa", "xoa", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            var queryTim= from sp in db.SanPhams
                          join lsp in db.LoaiSanPhams
                          on sp.MaLoai equals lsp.MaLoai 
                          group sp by lsp.TenLoai into nhom
                          select new
                          {
                              TenLoai=nhom.Key,
                              TongSoLuong=nhom.Sum(sp=>sp.SoLuong),
                              TongTien=nhom.Sum(sp=>sp.DonGia*sp.SoLuong)
                          };
            Window1 myWindow = new Window1();
            myWindow.dtgTim.ItemsSource =queryTim.ToList();
            myWindow.ShowDialog();
        }

        private void dtgNhanVien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dtgNhanVien.SelectedItem != null)
            {
                var dongChon=(dynamic)dtgNhanVien.SelectedItem;
                txtMa.Text = dongChon.MaSp;
                txtName.Text = dongChon.TenSp;
                cboLoai.Text = dongChon.TenLoai;
                txtDonGia.Text=dongChon.DonGia.ToString();
                txtSoLuong.Text=dongChon.SoLuong.ToString();
                

            }
        }
    }
} 