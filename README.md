# Mvc5FisrtSample
リレーションのあるテーブルが3つの、シンプルな MVC5 サンプルアプリです。

## 始め方
1. 本リモートリポジトリをクローンする。
1. ビルドを実行する。
1. Visual Studio パッケージマネージャーコンソールから、`Update-Database -Verbose` を実行する。
1. デバッグなしで開始 (Ctrl + F5) して、アプリの動作を確認する。

## サンプルアプリ概要
### MVC 関係
- スキャフォールディングで各テーブルのコントローラー、ビューをぱっと作って済ませた。
- 認証なし

### データベース関係
- データベース名: ApplicationDb
- テーブル
  - Parents
  - Children
  - Sexes ← 男、女が入っているだけのマスタテーブル
- リレーション
  - Parents 1-n Children
  - Parents n-1 Sexes
  - Children n-1 Sexes
- レコードから見るテーブルのリレーション表現は
  - Parents には Children 関係のカラムは無い。
  - Children は ParentsId カラムを持ち、親を指定する。
  - Parents と Children は SexId を持ち、性別を指定する。
  - Sexes には、他テーブル関係のカラムは無い。
- Sex テーブルは複数のテーブルから参照されるマスタであるため、cascadeDelete をオフに設定

## 詳細
- [【ASP.NET MVC5】ちょっとしたお試しをするときに土台となるアプリの作り方チュートリアル – oki2a24](http://oki2a24.com/2015/10/19/make-asp-net-mvc5-sample/)
