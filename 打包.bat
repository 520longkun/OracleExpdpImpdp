# 打包批处理
#-r包含子目录，-ag压缩文件后面加日期字符串格式，-x是要排除的路径，
#Oracle导入导出工具是产生的压缩文件名，@files.list中包含要打包的文件后缀
#最终生成的文件是【Oracle导入导出工具20181122.rar】
rar a -r -agYYYYMMDD -x*\DynamicFiles\* Oracle导入导出工具 @files.list