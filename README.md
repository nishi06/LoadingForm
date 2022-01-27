# LoadingForm

# FrmLoading クラス
 FrmLoading は 時間がかかる処理中に、読み込み中であることを示す画面を表示するクラスです。

# コンストラクター
## OleDBCommand()
 インスタンスを初期化します。

# 使用例
```
LoadingForm.FrmLoading loading = new LoadingForm.FrmLoading();
loading.Show();
loading.Update();

System.Threading.Thread.Sleep(5000);

loading.Close();
```