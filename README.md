# bpac-barcode
Based on the Brother b-PAC sampe code, this is a simple program which prints barcodes -- using either a GUI or the CLI.

## Requirements
- A compatible printer; I use a Brother QL710W
- Microsoft Windows
- [The b-PAC client component](http://www.brother.com/product/dev/label/bpac/download/index.htm); install 32- and 64-bit

## Usage
### GUI
Download [the latest release](https://github.com/limenet/bpac-barcode/releases/latest), unzip it, run `BarcodePrint.exe`, edit the fields, and hit "Print".

### CLI
`BarcodePrint.exe title barcode [timestamp = dd.mm.yyyy hh:mm] [copies = 1]`

Note:
- `[title]` and `[barcode]` are required, optionally enclosed in quotes.
- `[title]` can be any string
- `[barcode]` will be converted to a [Code 128 barcode](https://en.wikipedia.org/wiki/Code_128)
- `[timestamp]` is optional and defaults to the current date and time, but can be any string-
- `[copies]` is optional and defaults to 1.

## Templates
Every label roll has a different media ID and to print there has to be a file named `[media ID].lbx` in the same folder as `BarcodePrint.exe`. To figure out what your current media ID is, open the GUI version, and hit print. If your media ID is supported, a barcode will print, otherwise you'll see an error message telling you which media ID is currently in the printer.
