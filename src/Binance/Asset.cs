// ReSharper disable InconsistentNaming
using System;
using System.Collections.Generic;
using System.Linq;

namespace Binance
{
    /// <summary>
    /// Defined assets (for convenience/reference only).
    /// </summary>
    public sealed class Asset : IComparable<Asset>, IEquatable<Asset>
    {
        #region Public Constants

        /// <summary>
        /// When the assets were last updated.
        /// </summary>
        public static readonly long LastUpdateAt = 1511299718414;

        // Redirect (BCH) Bitcoin Cash (BCC = BitConnect)
        public static readonly Asset BCH = BCC;

        public static readonly Asset AMB = new Asset("AMB", 8);
        public static readonly Asset ARK = new Asset("ARK", 8);
        public static readonly Asset ARN = new Asset("ARN", 8);
        public static readonly Asset AST = new Asset("AST", 8);
        public static readonly Asset BAT = new Asset("BAT", 8);
        public static readonly Asset BCC = new Asset("BCC", 8);
        public static readonly Asset BCPT = new Asset("BCPT", 8);
        public static readonly Asset BNB = new Asset("BNB", 8);
        public static readonly Asset BNT = new Asset("BNT", 8);
        public static readonly Asset BQX = new Asset("BQX", 8);
        public static readonly Asset BTC = new Asset("BTC", 8);
        public static readonly Asset BTG = new Asset("BTG", 8);
        public static readonly Asset BTS = new Asset("BTS", 8);
        public static readonly Asset CDT = new Asset("CDT", 8);
        public static readonly Asset CTR = new Asset("CTR", 8);
        public static readonly Asset DASH = new Asset("DASH", 8);
        public static readonly Asset DLT = new Asset("DLT", 8);
        public static readonly Asset DNT = new Asset("DNT", 8);
        public static readonly Asset ENG = new Asset("ENG", 8);
        public static readonly Asset ENJ = new Asset("ENJ", 8);
        public static readonly Asset EOS = new Asset("EOS", 8);
        public static readonly Asset ETC = new Asset("ETC", 8);
        public static readonly Asset ETH = new Asset("ETH", 8);
        public static readonly Asset EVX = new Asset("EVX", 8);
        public static readonly Asset FUN = new Asset("FUN", 8);
        public static readonly Asset GAS = new Asset("GAS", 8);
        public static readonly Asset GVT = new Asset("GVT", 8);
        public static readonly Asset GXS = new Asset("GXS", 8);
        public static readonly Asset HSR = new Asset("HSR", 8);
        public static readonly Asset ICN = new Asset("ICN", 8);
        public static readonly Asset IOTA = new Asset("IOTA", 8);
        public static readonly Asset KMD = new Asset("KMD", 8);
        public static readonly Asset KNC = new Asset("KNC", 8);
        public static readonly Asset LINK = new Asset("LINK", 8);
        public static readonly Asset LRC = new Asset("LRC", 8);
        public static readonly Asset LTC = new Asset("LTC", 8);
        public static readonly Asset MCO = new Asset("MCO", 8);
        public static readonly Asset MDA = new Asset("MDA", 8);
        public static readonly Asset MOD = new Asset("MOD", 8);
        public static readonly Asset MTH = new Asset("MTH", 8);
        public static readonly Asset MTL = new Asset("MTL", 8);
        public static readonly Asset NEO = new Asset("NEO", 8);
        public static readonly Asset NULS = new Asset("NULS", 8);
        public static readonly Asset OAX = new Asset("OAX", 8);
        public static readonly Asset OMG = new Asset("OMG", 8);
        public static readonly Asset POE = new Asset("POE", 8);
        public static readonly Asset POWR = new Asset("POWR", 8);
        public static readonly Asset QSP = new Asset("QSP", 8);
        public static readonly Asset QTUM = new Asset("QTUM", 8);
        public static readonly Asset RCN = new Asset("RCN", 8);
        public static readonly Asset RDN = new Asset("RDN", 8);
        public static readonly Asset REQ = new Asset("REQ", 8);
        public static readonly Asset SALT = new Asset("SALT", 8);
        public static readonly Asset SNGLS = new Asset("SNGLS", 8);
        public static readonly Asset SNM = new Asset("SNM", 8);
        public static readonly Asset SNT = new Asset("SNT", 8);
        public static readonly Asset STORJ = new Asset("STORJ", 8);
        public static readonly Asset STRAT = new Asset("STRAT", 8);
        public static readonly Asset SUB = new Asset("SUB", 8);
        public static readonly Asset TRX = new Asset("TRX", 8);
        public static readonly Asset USDT = new Asset("USDT", 8);
        public static readonly Asset VEN = new Asset("VEN", 8);
        public static readonly Asset VIB = new Asset("VIB", 8);
        public static readonly Asset WTC = new Asset("WTC", 8);
        public static readonly Asset XMR = new Asset("XMR", 8);
        public static readonly Asset XRP = new Asset("XRP", 8);
        public static readonly Asset XVG = new Asset("XVG", 8);
        public static readonly Asset YOYO = new Asset("YOYO", 8);
        public static readonly Asset ZEC = new Asset("ZEC", 8);
        public static readonly Asset ZRX = new Asset("ZRX", 8);

        #endregion Public Constants

        #region Implicit Operators

        public static bool operator ==(Asset x, Asset y) => Equals(x, y);

        public static bool operator !=(Asset x, Asset y) => !(x == y);

        public static implicit operator string(Asset asset) => asset.ToString();

        public static implicit operator Asset(string s) => Cache.ContainsKey(s) ? Cache[s] : null;

        #endregion Implicit Operators

        #region Public Properties

        /// <summary>
        /// Asset cache.
        /// </summary>
        public static readonly IDictionary<string, Asset> Cache = new Dictionary<string, Asset>()
        {
            // Redirect (BCH) Bitcoin Cash (BCC = BitConnect)
            { "BCH", BCC },

            { "AMB", AMB },
            { "ARK", ARK },
            { "ARN", ARN },
            { "AST", AST },
            { "BAT", BAT },
            { "BCC", BCC },
            { "BCPT", BCPT },
            { "BNB", BNB },
            { "BNT", BNT },
            { "BQX", BQX },
            { "BTC", BTC },
            { "BTG", BTG },
            { "BTS", BTS },
            { "CDT", CDT },
            { "CTR", CTR },
            { "DASH", DASH },
            { "DLT", DLT },
            { "DNT", DNT },
            { "ENG", ENG },
            { "ENJ", ENJ },
            { "EOS", EOS },
            { "ETC", ETC },
            { "ETH", ETH },
            { "EVX", EVX },
            { "FUN", FUN },
            { "GAS", GAS },
            { "GVT", GVT },
            { "GXS", GXS },
            { "HSR", HSR },
            { "ICN", ICN },
            { "IOTA", IOTA },
            { "KMD", KMD },
            { "KNC", KNC },
            { "LINK", LINK },
            { "LRC", LRC },
            { "LTC", LTC },
            { "MCO", MCO },
            { "MDA", MDA },
            { "MOD", MOD },
            { "MTH", MTH },
            { "MTL", MTL },
            { "NEO", NEO },
            { "NULS", NULS },
            { "OAX", OAX },
            { "OMG", OMG },
            { "POE", POE },
            { "POWR", POWR },
            { "QSP", QSP },
            { "QTUM", QTUM },
            { "RCN", RCN },
            { "RDN", RDN },
            { "REQ", REQ },
            { "SALT", SALT },
            { "SNGLS", SNGLS },
            { "SNM", SNM },
            { "SNT", SNT },
            { "STORJ", STORJ },
            { "STRAT", STRAT },
            { "SUB", SUB },
            { "TRX", TRX },
            { "USDT", USDT },
            { "VEN", VEN },
            { "VIB", VIB },
            { "WTC", WTC },
            { "XMR", XMR },
            { "XRP", XRP },
            { "XVG", XVG },
            { "YOYO", YOYO },
            { "ZEC", ZEC },
            { "ZRX", ZRX },
        };

        /// <summary>
        /// Get the asset symbol.
        /// </summary>
        public string Symbol { get; }

        /// <summary>
        /// Get the asset precision.
        /// </summary>
        public int Precision { get; }

        #endregion Public Properties

        #region Private Fields

        private static readonly object _sync = new object();

        #endregion Private Fields

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="symbol">The asset symbol.</param>
        /// <param name="precision">The asset precision.</param>
        public Asset(string symbol, int precision)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentNullException(nameof(symbol));

            if (precision <= 0)
                throw new ArgumentException($"Asset precision must be greater than 0.", nameof(precision));

            Symbol = symbol;
            Precision = precision;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Update the asset cache.
        /// </summary>
        /// <param name="symbols">The symbols.</param>
        /// <returns></returns>
        public static void UpdateCache(IEnumerable<Symbol> symbols)
        {
            Throw.IfNull(symbols, nameof(symbols));

            if (symbols.Any())
                throw new ArgumentException("Enumerable must not be empty.", nameof(symbols));

            var assets = new List<Asset>();

            foreach (var symbol in symbols)
            {
                if (!assets.Contains(symbol.BaseAsset))
                    assets.Add(symbol.BaseAsset);

                if (!assets.Contains(symbol.QuoteAsset))
                    assets.Add(symbol.QuoteAsset);
            }

            lock (_sync)
            {
                // Remove any old assets (preserves redirections).
                foreach (var asset in Cache.Values.ToArray())
                {
                    if (!assets.Contains(asset))
                    {
                        Cache.Remove(asset);
                    }
                }

                // Update existing and add any new assets.
                foreach (var asset in assets)
                {
                    Cache[asset] = asset;
                }
            }
        }

        public override bool Equals(object obj)
        {
            return Symbol.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Symbol.GetHashCode();
        }

        public override string ToString()
        {
            return Symbol;
        }

        #endregion Public Methods

        #region IComparable<Asset>

        public int CompareTo(Asset other)
        {
            if (other == null)
                return 1;

            return Symbol.CompareTo(other.Symbol);
        }

        #endregion IComparable<Asset>

        #region IEquatable<Asset>

        public bool Equals(Asset other)
        {
            return CompareTo(other) == 0;
        }

        #endregion IEquatable<Asset>

        // File generated by BinanceCodeGenerator tool.
    }
}
