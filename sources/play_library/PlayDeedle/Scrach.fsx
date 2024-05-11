#r "nuget:Deedle"
open Deedle
System.IO.Directory.GetCurrentDirectory() // カレントディレクトリを確認する
#load "Deedle.fsx"
let df = Frame.ReadCsv "sources/data/シラバス.csv"
let row = df.Rows.GetAt(0)
row.Get("専門")
let aja = row.GetAs("専門")
row.GetAs<string>("専門")