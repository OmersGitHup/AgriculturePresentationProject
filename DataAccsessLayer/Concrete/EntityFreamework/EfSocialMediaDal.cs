﻿using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete.EntityFreamework
{
	public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
	{
	}
}
