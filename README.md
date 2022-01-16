# OwensT

Generate Owen's T Function Expected Value

## Definition

![define](https://github.com/tk-yoshimura/OwensT/blob/main/figures/define.svg)  

## Special Values

![special values](https://github.com/tk-yoshimura/OwensT/blob/main/figures/svalue.svg)  

## Properties

![symmetry](https://github.com/tk-yoshimura/OwensT/blob/main/figures/symmetry.svg)  
![formula](https://github.com/tk-yoshimura/OwensT/blob/main/figures/formula.svg)  

## Expected Value Generation

The Fast algorithm by Patefield and Tandy et al. is a method that uses six different algorithms depending on the region.
However, at accuracies higher than double, the algorithms diverge in some cases and approximations cannot be obtained.
Among the six algorithms, the Gaussian quadrature-based generation method is the most applicable to a wide range of domains and is stable without worrying about loss of digits.
In addition, since it is an even function, only half of the evaluation points in the quadrature method are needed.

![t5algo](https://github.com/tk-yoshimura/OwensT/blob/main/figures/t5algo.svg)  
[Gaussian quadrature Sampling Points](https://github.com/tk-yoshimura/LegendrePolynomialRoot)  

When h is large, the Gaussian quadrature method may not be able to correctly calculate because integrand f takes a small value in the region where x is large and the sample points are concentrated.

![gauss_integrand](https://github.com/tk-yoshimura/OwensT/blob/main/figures/gauss_integrand.svg)  
![integrand_hp5](https://github.com/tk-yoshimura/OwensT/blob/main/figures/integrand_hp5.svg)  
![integrand_h1](https://github.com/tk-yoshimura/OwensT/blob/main/figures/integrand_h1.svg)  
![integrand_h2](https://github.com/tk-yoshimura/OwensT/blob/main/figures/integrand_h2.svg)  
![integrand_h4](https://github.com/tk-yoshimura/OwensT/blob/main/figures/integrand_h4.svg)  
![integrand_h8](https://github.com/tk-yoshimura/OwensT/blob/main/figures/integrand_h8.svg)  
![integrand_h16](https://github.com/tk-yoshimura/OwensT/blob/main/figures/integrand_h16.svg)  

The definite integral of only the molecules of f can be obtained explicitly. When h is large, f and g become very close. 
Function d is always negative, and this difference widens as a increases, and the difference is zero when a=0.

![delta](https://github.com/tk-yoshimura/OwensT/blob/main/figures/delta.svg)  
![delta plot](https://github.com/tk-yoshimura/OwensT/blob/main/figures/delta_plot.svg)  
![delta df](https://github.com/tk-yoshimura/OwensT/blob/main/figures/delta_df.svg)  
![delta df2](https://github.com/tk-yoshimura/OwensT/blob/main/figures/delta_df2.svg)  

## Reference

Owen, D B. "Tables for computing bivariate normal probabilities". Annals of Mathematical Statistics, 27, 1075–1090. (1956)  
Patefield, M. and Tandy, D. "Fast and accurate Calculation of Owen’s T-Function", Journal of Statistical Software, 5 (5), 1–25. (2000) 